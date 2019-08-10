using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IAdminRepository
    {
        User GetAdminByUserId(int id);
        List<Admin> GetAdminsByDrivingSchoolId(int id);
    }
}
