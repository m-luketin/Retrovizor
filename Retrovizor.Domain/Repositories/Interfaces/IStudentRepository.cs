using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        bool AddStudent(Student studentToAdd);
        bool EditStudent(Student editedStudent);
        bool DeleteStudent(int idOfStudentToDelete);
        Student GetStudentById(int id);
        List<Student> GetStudentsByDrivingSchoolId(int id);
        List<Student> GetStudentsByInstructorId(int id);
        List<Student> GetCurrentStudentsByInstructorId(int id);
    }
}
