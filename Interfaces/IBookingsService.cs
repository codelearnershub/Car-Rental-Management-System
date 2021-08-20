using CarRentalsSystem.Models;
using CarRentalsSystem.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Service
{
    public interface IBookingsService
    {
        public Bookings AddBookings(CreateBookingsViewModel model);
        
        public Bookings SearchBookingById(int id);
        
        public Bookings UpdateBooking(UpdateBookingsViewModel model);
        
      

        public void DeleteBooking(int id);

        public List<BookingViewModel> GetBookings();
       
    }
}
