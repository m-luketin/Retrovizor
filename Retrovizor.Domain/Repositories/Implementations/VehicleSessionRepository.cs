using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class VehicleSessionRepository : IVehicleSessionRepository
    {
        public VehicleSessionRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public List<VehicleSession> GetAllVehicleSessions()
        {
            return _context.VehicleSessions.ToList();
        }
        public bool AddVehicleSession(VehicleSession vehicleSessionToAdd)
        {
            var doesVehicleExist = _context.Vehicles.Any(v => v.Id == vehicleSessionToAdd.VehicleId);
            var doesInstructorExist = _context.Instructors.Any(i => i.Id == vehicleSessionToAdd.InstructorId);
            var doesStudentExist = _context.Students.Any(s => s.Id == vehicleSessionToAdd.StudentId);

            if(!doesVehicleExist || !doesInstructorExist || !doesStudentExist)
                return false;

            var doesVehicleSessionExist = _context.VehicleSessions.Any(vehicleSession =>
                vehicleSession.StudentId == vehicleSessionToAdd.StudentId && 
                vehicleSession.InstructorId == vehicleSessionToAdd.InstructorId && 
                vehicleSession.VehicleId == vehicleSessionToAdd.VehicleId);

            if(doesVehicleSessionExist)
                return false;

            _context.VehicleSessions.Add(vehicleSessionToAdd);
            _context.SaveChanges();
            return true;
        }
        
        public bool DeleteVehicleSession(int idOfVehicleSessionToDelete)
        {
            var vehicleSessionToDelete = _context.VehicleSessions.Find(idOfVehicleSessionToDelete);

            if(vehicleSessionToDelete == null)
                return false;

            _context.Remove(vehicleSessionToDelete);
            _context.SaveChanges();
            return true;
        }
        public List<VehicleSession> GetVehicleSessionsByStudentId(int id)
        {
            return _context.VehicleSessions.Where(sc => id == sc.StudentId).ToList();
        }
        public List<VehicleSession> GetVehicleSessionsByInstructorId(int id)
        {
            return _context.VehicleSessions.Where(sc => id == sc.InstructorId).ToList();
        }
        public List<VehicleSession> GetVehicleSessionsByVehicleId(int id)
        {
            return _context.VehicleSessions.Where(sc => id == sc.VehicleId).ToList();
        }
    }
}
