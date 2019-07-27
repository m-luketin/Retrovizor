using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        //change password, validate password
    }
}
