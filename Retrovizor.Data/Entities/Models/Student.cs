using System;
using System.Collections.Generic;
using System.Text;
using Retrovizor.Data.Enums;

namespace Retrovizor.Data.Entities.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Category { get; set; }
        public ICollection<StudentClass> StudentClasses { get; set; }
        public ICollection<StudentEvent> StudentEvents { get; set; }
        public ICollection<StudentExam> StudentExams { get; set; }
        public ICollection<VehicleSession> VehicleSessions { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
