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

        public bool AddVehicleSession(VehicleSession vehicleSessionToAdd)
        {
            var doesInstructorExist = _context.Instructors.Any(i => i.Id == vehicleSessionToAdd.InstructorId);
            var doesStudentExist = _context.Students.Any(s => s.Id == vehicleSessionToAdd.StudentId);

            if(!doesInstructorExist || !doesStudentExist)
                return false;

            var vehicle = _context.Instructors.Find(vehicleSessionToAdd.InstructorId).Vehicle;
            if(vehicle == null)
                return false;

            var doesVehicleSessionExist = _context.VehicleSessions.Any(vehicleSession =>
                vehicleSession.StudentId == vehicleSessionToAdd.StudentId && 
                vehicleSession.InstructorId == vehicleSessionToAdd.InstructorId && 
                vehicleSession.VehicleId == vehicle.Id);

            if(doesVehicleSessionExist)
                return false;

            var instructor = _context.Instructors.Find(vehicleSessionToAdd.InstructorId);
            var student = _context.Students.Find(vehicleSessionToAdd.StudentId);

            _context.VehicleSessions.Add(
                new VehicleSession(){
                StudentId = student.Id,
                Student = student,
                InstructorId = instructor.Id,
                Instructor = instructor,
                Vehicle = vehicle,
                VehicleId = vehicle.Id,
                DateAssigned = DateTime.Now
            });
            _context.SaveChanges();
            return true;
        }
        
        public bool DeleteVehicleSession(int studentId, int instructorId, int vehicleId)
        {
            var vehicleSession = _context.VehicleSessions.Find(studentId, instructorId, vehicleId);

            if(vehicleSession == null)
                return false;

            _context.Remove(vehicleSession);
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
