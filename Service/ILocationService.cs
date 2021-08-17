using CarRentalsSystem.Models;
using CarRentalsSystem.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Service
{
    public interface ILocationService
    {
        public Location AddLocation(CreateLocationViewModel model);
        public Location SearchLocationById(int id);
        public Location UpdateLocation(UpdateLocationViewModel model);
        public void DeleteLocation(int id);
        public List<LocationViewModel> GetAllLocation();
    }
}
