using CarRentalsSystem.Models;
using CarRentalsSystem.Models.ViewModel;
using CarRentalsSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Service
{
    public class CarService :ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public Car AddCar(Car car)
        {          
            return _carRepository.AddCar(car);
        }
        public void Search(string searchText)
        {
            _carRepository.Search(searchText);
        }
        public Car UpdateCar(UpdateCarViewModel model)
        {
            var car = new Car
            {
            };
            return _carRepository.UpdateCar(car);
        }

        public void DeleteCar(int id)
        {
            _carRepository.Delete(id);
        }
        public List<CarViewModel> GetAllCar()
        {
            var car = _carRepository.GetAllCars().Select(c => new CarViewModel
            {
               
                CreatedAt = DateTime.Now

            }).ToList();
            return car;
        }

    }
}
