using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Data.Entities.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string FuelType { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
        public string LicensePlate { get; set; }
        public ICollection<VehicleSession> VehicleSessions { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
    }
}
