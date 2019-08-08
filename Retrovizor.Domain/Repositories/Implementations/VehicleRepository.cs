using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class VehicleRepository : IVehicleRepository
    {
        public VehicleRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public List<Vehicle> GetAllVehicles()
        {
            return _context.Vehicles.ToList();
        }

        public bool AddVehicle(Vehicle vehicleToAdd)
        {
            var doesVehicleExist = _context.Vehicles.Any(vehicle =>
                string.Equals(vehicle.LicensePlate, vehicleToAdd.LicensePlate, StringComparison.CurrentCultureIgnoreCase));

            if(doesVehicleExist)
                return false;

            _context.Vehicles.Add(vehicleToAdd);
            _context.SaveChanges();
            return true;
        }

        public bool EditVehicle(Vehicle editedVehicle)
        {
            var vehicleToEdit = _context.Vehicles.Find(editedVehicle.Id);

            if(vehicleToEdit == null)
                return false;

            vehicleToEdit.Manufacturer = editedVehicle.Manufacturer;
            vehicleToEdit.Model = editedVehicle.Model;
            vehicleToEdit.FuelType = editedVehicle.FuelType;
            vehicleToEdit.LicensePlate = editedVehicle.LicensePlate;
            vehicleToEdit.Picture = editedVehicle.Picture;
            vehicleToEdit.Type = editedVehicle.Type;

            _context.SaveChanges();
            return true;
        }

        public bool DeleteVehicle(int idOfVehicleToDelete)
        {
            var vehicleToDelete = _context.Vehicles.Find(idOfVehicleToDelete);

            if(vehicleToDelete == null)
                return false;

            _context.Remove(vehicleToDelete);
            _context.SaveChanges();
            return true;
        }

        public Vehicle GetVehicleById(int id)
        {
            return _context.Vehicles.Find(id);
        }

        public Vehicle GetCurrentVehicleByStudentId(int id)
        {
            var vehicleSessions = _context.VehicleSessions.Where(vs => vs.StudentId == id);

            if(vehicleSessions == null)
                return null;

            var currentVehicleSession = vehicleSessions.First();

            foreach(var vehicleSession in vehicleSessions)
                if(vehicleSession.DateAssigned - currentVehicleSession.DateAssigned < new TimeSpan(0))
                    currentVehicleSession = vehicleSession;

            return currentVehicleSession.Instructor.Vehicle;
        }

        public Vehicle GetCurrentVehicleByInstructorId(int id)
        {
            var instructor = _context.Instructors.Find(id);

            return instructor.Vehicle;
        }

        public List<Vehicle> GetVehiclesByInstructorId(int id)
        {
            var vehicleSessions = _context.VehicleSessions.Where(vs => vs.InstructorId == id);

            var vehicles = new List<Vehicle>();

            foreach(var vehicleSession in vehicleSessions)
                vehicles.Add(vehicleSession.Vehicle);

            return vehicles;
        }

        public List<Vehicle> GetVehiclesByStudentId(int id)
        {
            var vehicleSessions = _context.VehicleSessions.Where(vs => vs.StudentId == id).ToList();

            if(vehicleSessions == null)
                return null;

            var vehicles = new List<Vehicle>();

            foreach(var vehicleSession in vehicleSessions)
                vehicles.Add(vehicleSession.Vehicle);

            return vehicles;
        }
    }
}
