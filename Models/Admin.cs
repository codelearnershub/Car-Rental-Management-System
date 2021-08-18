using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models
{
    public class Admin:UniversalEntity
    {
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
