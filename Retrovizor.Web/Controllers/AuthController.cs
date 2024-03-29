﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Retrovizor.Domain.Classes;
using Retrovizor.Domain.Helpers;
using Retrovizor.Domain.Repositories.Interfaces;

namespace Retrovizor.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
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

        [HttpPost("refresh")]
        public IActionResult Refresh(Token token)
        {
            var accessTokenAsString = JwtHelper.GetTokenSubstring(Request.Headers["Authorization"].ToString());

            if (accessTokenAsString == "null") return Unauthorized();

            var userCredentials = JwtHelper.GetCredentialsFromToken(accessTokenAsString);

            var savedRefreshToken = _refreshTokenRepository.GetUserRefreshToken(token.Refresh, userCredentials.Id);

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

        [Authorize]
        [HttpDelete("delete-token")]
        public IActionResult DeleteToken()
        {
            var accessTokenAsString = JwtHelper.GetTokenSubstring(Request.Headers["Authorization"].ToString());
            var userCredentials = JwtHelper.GetCredentialsFromToken(accessTokenAsString);

            _refreshTokenRepository.DeleteRefreshToken(userCredentials.Id.ToString());
            return Ok();
        }

        [Authorize]
        [HttpGet("get-role")]
        public IActionResult GetRole()
        {
            var accessTokenAsString = JwtHelper.GetTokenSubstring(Request.Headers["Authorization"].ToString());
            var userCredentials = JwtHelper.GetCredentialsFromToken(accessTokenAsString);

            var role = _refreshTokenRepository.GetRole(userCredentials.Id);
            if (string.IsNullOrEmpty(role))
                return NotFound();

            return Ok(role);
        }
    }
}
