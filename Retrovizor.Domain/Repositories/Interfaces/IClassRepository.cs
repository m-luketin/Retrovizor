using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IClassRepository
    {
        List<Class> GetAllClassesByDrivingSchoolId(int id);
        bool AddClass(Class classToAdd, int drivingSchoolId);
        bool EditClass(Class editedClass, int drivingSchoolId);
        bool DeleteClass(int idOfClassToDelete, int drivingSchoolId);
        Class GetClassById(int id, int drivingSchoolId);
        List<Class> GetClassesByStudentId(int id, int drivingSchoolId);
    }
}
