
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models
{
    public class Bookings : BaseEntity
    {  
        [Key]
        public string Booking_ref { get; set; }
        public User User { get; set; }
        public Car Car { get; set; }  
        public Location Location { get; set; }
        public DateTime Booking_Date { get; set; }
        public DateTime Return_Date { get; set; }
        public int UserId { get;set; }
    }
}
