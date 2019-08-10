using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Data.Enums;
using Retrovizor.Domain.Repositories.Interfaces;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class RefreshTokenRepository : IRefreshTokenRepository
    {
        public RefreshTokenRepository(RetrovizorContext context)
        {
            _context = context;
        }

        private readonly RetrovizorContext _context;

        public string GetUserRefreshToken(string token, int userId)
        {
            var refreshToken = _context.RefreshTokens.Include(rt => rt.User)
                .FirstOrDefault(rt => rt.User.Id == userId && rt.Value == token);

            if (refreshToken == null) return null;

            return refreshToken.Value;
        }

        public bool AddRefreshToken(string token, int userId)
        {
            var tokenExists = _context.RefreshTokens.Any(rt => rt.Value == token);
            var user = _context.Users.Find(userId);

            if (tokenExists) return false;

            var newRefreshToken = new RefreshToken
            {
                User = user,
                Value = token
            };

            _context.RefreshTokens.Add(newRefreshToken);
            _context.SaveChanges();
            return true;
        }

        public bool RevokeUserTokens(int userId)
        {
            var user = _context.Users.Include(u => u.RefreshTokens).First(u => u.Id == userId);

            _context.RemoveRange(user.RefreshTokens);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteRefreshToken(string token)
        {
            var userId = 0;
            var tokenToDelete = new RefreshToken();

            if (token.Length <= 4)
                userId = int.Parse(token);

            if (userId != 0)
                tokenToDelete = _context.RefreshTokens.Where(rt => rt.UserId == userId).ToList()[0];
            else
                tokenToDelete = _context.RefreshTokens.FirstOrDefault(rt => rt.Value == token);

            if (tokenToDelete == null) return false;

            _context.RefreshTokens.Remove(tokenToDelete);
            _context.SaveChanges();
            return true;
        }

        public string GetRole(int userId)
        {
            var user = _context.Users
                .Include("Student")
                .Include("Instructor")
                .Include("Admin")
                .FirstOrDefault(u => u.Id == userId);

            if (user == null)
                return null;

            if (user.Student != null)
                return "kandidat";

            if (user.Instructor != null)
                return "instruktor";

            return "aministrator";
        }
    }
}
