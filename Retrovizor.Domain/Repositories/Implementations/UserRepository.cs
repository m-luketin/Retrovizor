using System;
using System.Linq;
using CashRegister.Data.Helpers;
using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Data.Enums;
using Retrovizor.Domain.Classes;
using Retrovizor.Domain.Repositories.Interfaces;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(RetrovizorContext context)
        {
            _context = context;
        }

        private readonly RetrovizorContext _context;

        public UserCredentials VerifyCredentials(UserCredentials credentials)
        {
            var userMatch = _context.Users.FirstOrDefault(u => u.Username == credentials.Username
                && HashHelper.ValidatePassword(credentials.Password, u.Password));

           if (userMatch == null) return null;

            credentials.Id = userMatch.Id;
            credentials.Role = userMatch.Role;

            return credentials;
        }
    }
}
