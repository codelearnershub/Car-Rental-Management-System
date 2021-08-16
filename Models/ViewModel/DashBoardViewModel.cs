using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models
{
    public class DashBoardViewModel
    {
        [Required]
        public User User { get; set; }
    }
}
