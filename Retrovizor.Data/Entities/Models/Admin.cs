using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Data.Entities.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int DrivingSchoolId { get; set; }
        public DrivingSchool DrivingSchool { get; set; }
    }
}
