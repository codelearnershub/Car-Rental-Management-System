using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models
{
    public class Customer:UniversalEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
