using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models
{
    public class Payment:BaseEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
        public string PaymentDate { get; set; }
        public Bookings Bookings { get; set; }
        public int BookingsId { get; set; }
        public Decimal AmountPaid { get; set; }
    }
}
