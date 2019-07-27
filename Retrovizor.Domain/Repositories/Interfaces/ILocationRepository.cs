using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface ILocationRepository
    {
        List<Location> GetAllLocations();
        bool AddLocation(Location locationToAdd);
        bool EditLocation(Location editedLocation);
        bool DeleteLocation(int idOfLocationToDelete);
        Location GetLocationById(int id);
        Location GetLocationByEventId(int id);
    }
}
