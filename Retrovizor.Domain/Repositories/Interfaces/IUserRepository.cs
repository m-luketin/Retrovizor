using System;
using Retrovizor.Data.Entities.Models;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IUserRepository
    {
        bool AddUser(User userToAdd);
        bool EditUser(User editedUser);
    }
}
