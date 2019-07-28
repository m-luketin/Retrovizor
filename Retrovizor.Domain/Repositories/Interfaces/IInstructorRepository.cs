using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IInstructorRepository
    {
        List<Instructor> GetAllInstructorsByDrivingSchoolId(int id);
        bool AddInstructor(Instructor instructorToAdd);
        bool EditInstructor(Instructor editedInstructor);
        bool DeleteInstructor(int idOfInstructorToDelete);
        Instructor GetInstructorById(int id);
        Instructor GetCurrentInstructorByStudentId(int id);
        List<Instructor> GetInstructorsByDrivingSchoolId(int id);
    }
}
