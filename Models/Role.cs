using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models
{
    public class Role : BaseEntity
    {

        //public int UserId { get; set; }
        public string Name { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    }
}
