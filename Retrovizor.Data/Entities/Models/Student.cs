using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Data.Entities.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string OIB { get; set; }
        public string Param { get; set; }
        public string Category { get; set; }
        public int DrivingSchoolId { get; set; }
        public DrivingSchool DrivingSchool { get; set; }
        public ICollection<StudentClass> StudentClasses { get; set; }
        public ICollection<StudentEvent> StudentEvents { get; set; }
        public ICollection<StudentExam> StudentExams { get; set; }
        public ICollection<StudentInstructor> StudentInstructors { get; set; }
        public ICollection<VehicleSession> VehicleSessions { get; set; }
    }
}
