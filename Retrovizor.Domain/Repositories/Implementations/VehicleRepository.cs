using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            vehicleToEdit.Image = editedVehicle.Image;
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
    }
}
