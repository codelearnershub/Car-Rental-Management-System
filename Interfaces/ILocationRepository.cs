using CarRentalsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Repositories
{
    public interface ILocationRepository
    {
        public Location AddLocation(Location location);
        public Location SearchLocationById(int id);
        public Location UpdateLocation(Location location);
        public void DeleteLocation(int id);
        public List<Location> GetLocation();
    }
}

