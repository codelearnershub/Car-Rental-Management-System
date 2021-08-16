using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models
{
    public class Role : BaseEntity
    { 
        public string Name { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
