using System;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Classes;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IUserRepository
    {
        UserCredentials VerifyCredentials(UserCredentials credentials);
    }
}
