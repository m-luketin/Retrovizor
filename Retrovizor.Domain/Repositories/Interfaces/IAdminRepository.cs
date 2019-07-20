using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IAdminRepository
    {
        List<Admin> GetAllAdmins();
        Admin GetAdminById(int id);
    }
}
