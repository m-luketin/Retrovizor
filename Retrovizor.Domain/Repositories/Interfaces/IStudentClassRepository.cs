using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IStudentClassRepository
    {
        bool AddStudentClass(StudentClass studentClassToAdd);
        bool EditStudentClass(StudentClass editedStudentClass);
        bool DeleteStudentClass(int studentId, int classId);

        StudentClass GetStudentClass(int studentId, int classId);
    }
}
