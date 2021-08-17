using CarRentalsSystem.Models;
using CarRentalsSystem.Models.ViewModel;
using CarRentalsSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Service
{
    public class LocationService:ILocationService
    {
        private readonly ILocationRepository _locationRepository;
        public readonly ICarRepository _carRepository;

        public LocationService(ILocationRepository locationRepository, ICarRepository carRepository)
        {
            _locationRepository = locationRepository;
            _carRepository = carRepository;
        }
        public Location AddLocation(CreateLocationViewModel model)
        {
            var location = new Location
            {
                Name = model.Name,
                Address = model.Address,
                CreatedAt = DateTime.Now
            };

            return _locationRepository.AddLocation(location);
        }
        public Location SearchLocationById(int id)
        {
            return _locationRepository.SearchLocationById(id);
        }
        public Location UpdateLocation(UpdateLocationViewModel model)
        {
            var location = new Location
            { Id = model.Id,
                Name = model.Name,
                Address = model.Address
            };
            return _locationRepository.UpdateLocation(location);
        }

        public void DeleteLocation(int id)
        {
            _locationRepository.DeleteLocation(id);
        }
        public List<LocationViewModel> GetAllLocation()
        {
            var location = _locationRepository.GetLocation().Select(c => new LocationViewModel
            { Id = c.Id,
                Name = c.Name,
                Address = c.Address,
                CreatedAt = DateTime.Now

            }).ToList();
            return location;
        }
        

    }
}
