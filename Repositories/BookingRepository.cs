using CarRentalsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        public readonly RentalsDbContext _dbContext;
        public BookingRepository(RentalsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Bookings AddBookings(Bookings bookings)
        {
            _dbContext.Bookings.Add(bookings);
            _dbContext.SaveChanges();
            return bookings;
        }
        public Bookings SearchBookingsById(int id)
        {
            return _dbContext.Bookings.Find(id);
        }
        public Bookings UpdateBooking(Bookings bookings)
        {
            _dbContext.Bookings.Update(bookings);
            _dbContext.SaveChanges();
            return bookings;
        }
        public void DeleteBooking(int id)
        {
            var bookings = SearchBookingsById(id);
            if (bookings != null)
            {
                _dbContext.Bookings.Remove(bookings);
                _dbContext.SaveChanges();
            }
        }

        public List<Bookings> GetBookings()
        {
            return _dbContext.Bookings.ToList();
        }
        public List<Bookings> BookingHistoryPerUser(int userId)
        {
            return _dbContext.Bookings.Where(c => c.UserId == userId).ToList();
        }
    }  
}
