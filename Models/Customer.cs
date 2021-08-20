using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models
{
    public class Customer : UniversalEntity
    {
        public object Email { get; internal set; }
        public object UserId { get; internal set; }
    }
}
