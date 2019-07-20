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
        AdminRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public List<Admin> GetAllAdmins()
        {
            return _context.Admins.ToList();
        }

        public Admin GetAdminById(int id)
        {
            return _context.Admins.Find(id);
        }
    }
}
