using System;
using System.Linq;
using Retrovizor.Data.Entities;
using Retrovizor.Data.Enums;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class RefreshTokenRepository
    {
        public RefreshTokenRepository(RetrovizorContext context)
        {
            _context = context;
        }

        private readonly RetrovizorContext _context;

        /*public string GetUserRefreshToken(string username, Role role)
        {
            if (role == Role.Admin)
                return _context.RefreshTokens.
        }*/
    }
}
