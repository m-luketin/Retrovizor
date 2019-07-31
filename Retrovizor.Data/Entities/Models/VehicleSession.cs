using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Data.Entities.Models
{
    public class VehicleSession
    {
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime DateAssigned { get; set; }
        public bool IsActive { get; set; }
    }
}
