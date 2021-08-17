using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models
{
    public class Category:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public  List<Car_CarCategory> CarCarCategories { get; internal set; }
    }
}
