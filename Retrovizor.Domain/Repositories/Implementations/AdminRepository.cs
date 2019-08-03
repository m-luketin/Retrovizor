using CashRegister.Data.Helpers;
using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Data.Enums;
using Retrovizor.Domain.Classes;
using Retrovizor.Domain.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class AdminRepository : IAdminRepository
    {
        public AdminRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;
       
        public List<Admin> GetAdminsByDrivingSchoolId(int id)
        {
            return _context.Admins.Where(a => a.DrivingSchoolId == id).ToList();
        }

        public UserCredentials VerifyCredentials(UserCredentials credentials)
        {
            var adminMatch = _context.Admins.FirstOrDefault(a => a.Username == credentials.Username
            && HashHelper.ValidatePassword(credentials.Password, a.Password));

            if (adminMatch == null) return null;

            credentials.Id = adminMatch.Id;
            credentials.Role = (Role)2;

            return credentials;
        }
    }
}
