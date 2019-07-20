using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IStudentClassRepository
    {
        List<StudentClass> GetAllStudentClasses();
        bool AddStudentClass(StudentClass studentClassToAdd);
        bool EditStudentClass(StudentClass editedStudentClass);
        bool DeleteStudentClass(int idOfStudentClassToDelete);
        List<StudentClass> GetStudentClassesByStudentId(int id);
        List<StudentClass> GetStudentClassesByClassId(int id);
    }
}
