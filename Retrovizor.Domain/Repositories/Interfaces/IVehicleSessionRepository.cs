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
        VehicleSession GetVehicleSessionByVehicleId(int id);
        VehicleSession GetVehicleSessionByInstructorId(int id);
        VehicleSession GetVehicleSessionByStudentId(int id);
    }
}