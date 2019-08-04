using System;
using System.Linq;
using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Data.Enums;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class UserRepository
    {
        public UserRepository(RetrovizorContext context)
        {
            _context = context;
        }

        private readonly RetrovizorContext _context;

        public bool AddUser(User userToAdd)
        {
            if (_context.Users.Any(u => u.Username == userToAdd.Username
            || u.OIB == userToAdd.OIB || u.PhoneNumber == userToAdd.PhoneNumber)) return false;

            _context.Users.Add(userToAdd);
 
            return true;
        }

       /* public bool EditUser(User editedUser)
        {
            if (editedUser.Role )

            return true;
        }*/
    }
}
