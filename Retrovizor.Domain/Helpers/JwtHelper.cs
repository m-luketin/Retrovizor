using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Retrovizor.Data.Enums;
using Retrovizor.Domain.Classes;

namespace Retrovizor.Domain.Helpers
{
    public class JwtHelper
    {
        public JwtHelper(IConfiguration configuration)
        {
            _issuer = configuration["JWT:Issuer"];
            _audience = configuration["JWT:Audience"];
            _secret = configuration["JWT:Secret"];
        }

        private readonly string _issuer;
        private readonly string _audience;
        private readonly string _secret;

        public string GetAccessToken(UserCredentials userToGenerateFor)
        {
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secret));

            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, $"{userToGenerateFor.Id}"),
                new Claim(ClaimTypes.Name, $"{userToGenerateFor.Username}"),
                new Claim(ClaimTypes.Role, $"{userToGenerateFor.Role}"),
            };

            var token = new JwtSecurityToken(
                issuer: _issuer,
                audience: _audience,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256),
                claims: claims
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public string GetRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }
    }
}
