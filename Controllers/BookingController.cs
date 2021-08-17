using CarRentalsSystem.Models.ViewModel;
using CarRentalsSystem.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Controllers
{
    public class BookingController : Controller
    {
        public readonly IBookingsService _bookingsService;
        public BookingController(IBookingsService bookingService)
        {
            _bookingsService = bookingService;
        }
        public IActionResult Index()
        {
            var bookings = _bookingsService.GetBookings(); 
            return View(bookings);
        }
        [HttpGet]
       
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateBookingsViewModel model)
        {
            _bookingsService.AddBookings(model);
            return RedirectToAction("Index");
        }
        public IActionResult Find()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Find(int id)
        {
            _bookingsService.SearchBookingById(id);
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdateBookingsViewModel model)
        {
            _bookingsService.UpdateBooking(model);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
        
            var bookings = _bookingsService.SearchBookingById(id);
            if (bookings == null)
            {
                return NotFound();
            }
            _bookingsService.DeleteBooking(id);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var bookings = _bookingsService.SearchBookingById(id);
            if (bookings == null)
            {
                return NotFound();
            }
            return View(bookings);
        }

    }
}
