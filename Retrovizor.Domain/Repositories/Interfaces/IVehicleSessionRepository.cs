using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IVehicleSessionRepository
    {
        List<VehicleSession> GetAllVehicleSessions();
        bool AddVehicleSession(VehicleSession vehicleSessionToAdd);
        bool DeleteVehicleSession(int idOfVehicleSessionToDelete);
        List<VehicleSession> GetVehicleSessionsByStudentId(int id);
        List<VehicleSession> GetVehicleSessionsByInstructorId(int id);
        List<VehicleSession> GetVehicleSessionsByVehicleId(int id);
    }
}