using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IClassRepository
    {
        List<Class> GetAllClassesByDrivingSchoolId(int id);
        bool AddClass(Class classToAdd);
        bool EditClass(Class editedClass);
        bool DeleteClass(int idOfClassToDelete);
        Class GetClassById(int id);
        List<Class> GetClassesByStudentId(int id);
    }
}
