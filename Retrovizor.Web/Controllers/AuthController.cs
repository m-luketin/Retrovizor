using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Retrovizor.Data.Enums;
using Retrovizor.Domain.Classes;
using Retrovizor.Domain.Helpers;
using Retrovizor.Domain.Repositories.Interfaces;

namespace Retrovizor.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        public AuthController(JwtHelper jwtHelper, IUserRepository userRepository, IRefreshTokenRepository refreshTokenRepository)
        {
            _refreshTokenRepository = refreshTokenRepository;
            _userRepository = userRepository;
            _jwtHelper = jwtHelper;
        }

        private readonly IRefreshTokenRepository _refreshTokenRepository;
        private readonly IUserRepository _userRepository;
        private readonly JwtHelper _jwtHelper;

        [HttpPost("login")]
        public IActionResult Login(UserCredentials credentials)
        {            
            var verifiedCredentials = _userRepository.VerifyCredentials(credentials);

            if (verifiedCredentials == null) return BadRequest("Username or password is incorrect!");

            var accessToken = _jwtHelper.GetAccessToken(verifiedCredentials);
            var refreshToken = _jwtHelper.GetRefreshToken();

            if (!_refreshTokenRepository.AddRefreshToken(refreshToken, verifiedCredentials.Id)) return Unauthorized();

            return Ok(new Token(accessToken, refreshToken));
        }

        [Authorize]
        [HttpPost("refresh")]
        public IActionResult Refresh(string refreshToken)
        {
            var accessTokenAsString = JwtHelper.GetTokenSubstring(Request.Headers["Authorization"].ToString());
            var userCredentials = JwtHelper.GetCredentialsFromToken(accessTokenAsString);

            var savedRefreshToken = _refreshTokenRepository.GetUserRefreshToken(refreshToken, userCredentials.Id);

            if (savedRefreshToken == null) throw new SecurityTokenException("Invalid refresh token!");

            var newJwtToken = _jwtHelper.GetAccessToken(userCredentials);
            var newRefreshToken = _jwtHelper.GetRefreshToken();

            if (!_refreshTokenRepository.AddRefreshToken(newRefreshToken, userCredentials.Id)) return Unauthorized();

            if (!_refreshTokenRepository.DeleteRefreshToken(savedRefreshToken)) return Unauthorized();

            return Ok(new Token(newJwtToken, newRefreshToken));
        }

        [Authorize]
        [HttpPost("revoke-tokens")]
        public IActionResult RevokeTokens()
        {
            var accessTokenAsString = JwtHelper.GetTokenSubstring(Request.Headers["Authorization"].ToString());
            var userCredentials = JwtHelper.GetCredentialsFromToken(accessTokenAsString);

            _refreshTokenRepository.RevokeUserTokens(userCredentials.Id);
            return Ok();
        }
    }
}
