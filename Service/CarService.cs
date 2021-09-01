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
        public Car Create(Car car)
        {
           return _carRepository.Create(car);
        }
       
        public Car AddCar(CreateCarViewModel model)
        {
            var car = new Car
           {
                Make = model.Make,
                 Name = model.Name,
                 Year = model.Year,
                 PlateNo = model.PlateNo,
                 Features = model.Features,
                 BreakdownPrice = model.BreakdownPrice,
                 LocationId = model.LocationId,
                 CategoryId = model.CategoryId,
                 Price =model.Price,
                 InternalImage = model.InternalImage,
                 CarPictureUrl =model.CarPictureUrl,
                 CreatedAt =DateTime.Now
            };

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
            return _carRepository.Update(car);
        }

        public void DeleteCar(int id)
        {
            _carRepository.Delete(id);
        }
        /* public List<CarViewModel> GetAllCar()
         {
             var car = _carRepository.GetAllCar().Select(c => new CarViewModel
             {

                 CreatedAt = DateTime.Now

             }).ToList();
             return car;
         }*/
       /* public IEnumerable<Car> GetAll()
        {
            return _carRepository.GetAll();

        }
*/
         public List<Car> GetAll()
        {
            return _carRepository.GetAll();

        }

    }
}
