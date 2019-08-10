using System;
namespace Retrovizor.Domain.Classes
{
    public class VehicleDTO
    {
        public VehicleDTO(string model, int year)
        {
            Model = model;
            Year = year;
        }

        public string Model { get; set; }
        public int Year { get; set; }
    }
}
