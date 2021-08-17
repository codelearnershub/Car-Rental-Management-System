using CarRentalsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Repositories
{
    public class LocationRepository:ILocationRepository
    
    {
        public readonly RentalsDbContext _dbContext;
        
        public LocationRepository(RentalsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Location AddLocation(Location location)
        {
           

            _dbContext.Locations.Add(location);
            _dbContext.SaveChanges();
            return location;
        }
        public Location SearchLocationById(int id)
        {
            return _dbContext.Locations.Find(id);
        }
        public Location UpdateLocation(Location location)
        {
            _dbContext.Locations.Update(location);
            _dbContext.SaveChanges();
            return location;
        }
        public void DeleteLocation(int id)
        {
            var location = SearchLocationById(id);
            if (location != null)
            {
                _dbContext.Locations.Remove(location);
                _dbContext.SaveChanges();
            }
        }
        public List<Location> GetLocation()
        {
            return _dbContext.Locations.ToList();
        }
        public List<Location> GetAll(IEnumerable<int> locationId)
        {
            return _dbContext.Locations.Where(location => locationId.Contains(location.CarId)).ToList();

        }
       /* public List<Car> GetAll(IEnumerable<int> carId)
        {
            return _dbContext.Cars.Where(item => carId.Contains(item.LocationId)).ToList();

        }
*/
    }
}
