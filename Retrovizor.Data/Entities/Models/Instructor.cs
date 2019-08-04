using System;
using System.Collections.Generic;
using System.Text;
using Retrovizor.Data.Enums;

namespace Retrovizor.Data.Entities.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<VehicleSession> VehicleSessions { get; set; }
    }
}
