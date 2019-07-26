using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class DrivingSchoolRepository : IDrivingSchoolRepository
    {
        public DrivingSchoolRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public List<DrivingSchool> GetAllDrivingSchools()
        {
            return _context.DrivingSchools.ToList();
        }

        public DrivingSchool GetDrivingSchoolById(int id)
        {
            return _context.DrivingSchools.Find(id);
        }
        public DrivingSchool GetDrivingSchoolByStudentId(int id)
        {
            var student = _context.Students.Find(id);

            return _context.DrivingSchools.Find(student.DrivingSchoolId);
        }
        public DrivingSchool GetDrivingSchoolByInstructorId(int id)
        {
            var instructor = _context.Instructors.Find(id);

            return _context.DrivingSchools.Find(instructor.DrivingSchoolId);
        }
    }
}
