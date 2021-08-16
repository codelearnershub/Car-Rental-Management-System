using CarRentalsSystem.Models;
using System.Collections.Generic;

namespace CarRentalsSystem.Repositories
{
    public interface IBookingRepository
    {
        public Bookings AddBookings(Bookings bookings);
        public Bookings SearchBookingsById(int id);
        public Bookings UpdateBooking(Bookings bookings);
        public void DeleteBooking(int id);
        public List<Bookings> GetBookings();     
    }
}