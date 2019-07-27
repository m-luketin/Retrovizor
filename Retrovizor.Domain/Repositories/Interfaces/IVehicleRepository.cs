using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IVehicleRepository
    {
        List<Vehicle> GetAllVehicles();
        bool AddVehicle(Vehicle vehicleToAdd);
        bool EditVehicle(Vehicle editedVehicle);
        bool DeleteVehicle(int idOfVehicleToDelete);
        Vehicle GetVehicleById(int id);
        Vehicle GetCurrentVehicleByStudentId(int id);
        Vehicle GetCurrentVehicleByInstructorId(int id);
        List<Vehicle> GetVehiclesByStudentId(int id);
        List<Vehicle> GetVehiclesByInstructorId(int id);
    }
}
