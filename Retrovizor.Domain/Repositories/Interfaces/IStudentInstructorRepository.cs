using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IStudentInstructorRepository
    {
        List<StudentInstructor> GetAllStudentInstructors();
        bool AddStudentInstructor(StudentInstructor studentInstructorToAdd);
        bool EditStudentInstructor(StudentInstructor editedStudentInstructor);
        bool DeleteStudentInstructor(int idOfStudentInstructorToDelete);
        StudentInstructor GetStudentInstructorByStudentId(int id);
        StudentInstructor GetStudentInstructorByInstructorId(int id);
    }
}