using CarRentalsSystem.Models;
using CarRentalsSystem.Models.ViewModel;
using CarRentalsSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Service
{
    public class BookingsService:IBookingsService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingsService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        private string GenerateBookingRef()
        {

            Random random = new Random();

            string numberInReg = random.Next(0, 1000000).ToString("000000");

            return $"{GenerateRandomCharacter()}{GenerateRandomCharacter()}{numberInReg}{GenerateRandomCharacter()}";
            
        }

        private static char GenerateRandomCharacter()
        {
            Random random = new Random();
            int randomCharNum = random.Next(65, 91);
            char letter = (char)randomCharNum;
            return letter;
        }

        private bool RefExist(List<BookingViewModel> allBookings, string b_ref)
        {
            foreach(var b in allBookings)
            {
                if (b.Booking_ref.Equals(b_ref))
                {
                    return true;
                }
            }
            return false; 
        }

        public Bookings AddBookings(CreateBookingsViewModel model)
        {
            List<BookingViewModel> allBookings = GetBookings();
            string b_ref = "";
            do
            {
                b_ref = GenerateBookingRef();
            } 
            while (RefExist(allBookings, b_ref));

            var bookings = new Bookings
            {
                Id = model.Car_Id,
                Booking_ref = b_ref,
               
               
                CreatedAt = DateTime.Now
            };

            return _bookingRepository.AddBookings(bookings);
        }
        public Bookings SearchBookingById(int id)
        {
            return _bookingRepository.SearchBookingsById(id);
        }
        public Bookings UpdateBooking(UpdateBookingsViewModel model)
        {
            var booking = new Bookings
            {Id = model.Id,
                Booking_ref = model.Booking_ref,
               
            };
            return _bookingRepository.UpdateBooking(booking);
        }

        public void DeleteBooking(int id)
        {
            _bookingRepository.DeleteBooking(id);
        }
        public List<BookingViewModel> GetBookings()
        {
            var bookings = _bookingRepository.GetBookings().Select(c => new BookingViewModel
            {
                Id=c.Id,
                Booking_ref = c.Booking_ref,
               
             
                CreatedAt = DateTime.Now
            }).ToList();
            return bookings;
        }
    }
}
