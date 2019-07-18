﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Data.Entities.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public int DrivingSchoolId { get; set; }
        public DrivingSchool DrivingSchool { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<StudentInstructor> StudentInstructors { get; set; }
        public ICollection<VehicleSession> VehicleSessions { get; set; }
    }
}
