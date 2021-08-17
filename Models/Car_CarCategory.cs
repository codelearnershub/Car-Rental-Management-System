using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models
{
    public class Car_CarCategory:BaseEntity
    {
        public Car Car { get; set; }
        public int CarId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
