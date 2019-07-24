using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class LocationRepository : ILocationRepository
    {
        public LocationRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public List<Location> GetAllLocations()
        {
            return _context.Locations.ToList();
        }
        public bool AddLocation(Location locationToAdd)
        {
            var doesLocationExist = _context.Locations.Any(c =>
                string.Equals(c.Address, locationToAdd.Address, StringComparison.CurrentCultureIgnoreCase));

            if(doesLocationExist)
                return false;

            _context.Locations.Add(locationToAdd);
            _context.SaveChanges();
            return true;
        }
        public bool EditLocation(Location editedLocation)
        {
            var doesLocationExist = _context.Locations.Any(c =>
                string.Equals(c.Address, editedLocation.Address, StringComparison.CurrentCultureIgnoreCase));

            if(doesLocationExist)
                return false;

            var locationToEdit = _context.Locations.Find(editedLocation.Id);

            if(locationToEdit == null)
                return false;

            locationToEdit.Address = editedLocation.Address;
            locationToEdit.Latitude = editedLocation.Latitude;
            locationToEdit.Longitude = editedLocation.Longitude;

            _context.SaveChanges();
            return true;
        }
        public bool DeleteLocation(int idOfLocationToDelete)
        {
            var locationToDelete = _context.Locations.Find(idOfLocationToDelete);

            if(locationToDelete == null)
                return false;

            _context.Remove(locationToDelete);
            _context.SaveChanges();
            return true;
        }
        public Location GetLocationById(int id)
        {
            return _context.Locations.Find(id);
        }
    }
}
