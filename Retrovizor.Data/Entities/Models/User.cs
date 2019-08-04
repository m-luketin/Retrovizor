using System;
using System.Collections.Generic;
using Retrovizor.Data.Enums;

namespace Retrovizor.Data.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string OIB { get; set; }
        public string PhoneNumber { get; set; }
        public Role Role { get; set; }
        public Admin Admin { get; set; }
        public Instructor Instructor { get; set; }
        public Student Student { get; set; }
        public int DrivingSchoolId { get; set; }
        public DrivingSchool DrivingSchool { get; set; }
        public ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}
