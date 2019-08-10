using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IDrivingSchoolRepository
    {
        List<DrivingSchool> GetAllDrivingSchools();
        DrivingSchool GetDrivingSchoolById(int id);
        DrivingSchool GetDrivingSchoolByStudentId(int id);
        DrivingSchool GetDrivingSchoolByInstructorId(int id);
        DrivingSchool GetDrivingSchoolByAdminId(int id);
        int GetStudentCount(int id);
        int GetInstructorCount(int id);
    }
}
