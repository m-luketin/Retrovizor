using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IAdminRepository
    {
        List<Admin> GetAdminsByDrivingSchoolId(int id);
        UserCredentials VerifyCredentials(UserCredentials userToVerify);
    }
}
