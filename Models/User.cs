 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models
{
    public class User: BaseEntity
    {

        //public Customer Customer { get; set; }
        /* public int CustomerId { get; set; }
         public Role Role { get; set; }
         public int RoleId { get; set; }
         public Admin Admin { get; set; }
         public int AdminId { get; set; }*/

        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public string ConfirmPassword { get; set; }
        [Required]
        public string HashSalt { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string PhoneNo { get; set; }

        public string Address { get; set; }
        [Required]
        public string Gender { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
        //public string AccountNumber { get; set; }
        //[Required]
        //public string CardNo { get; set; }
        //[Required]
        //public int CardPin { get; set; }

    }
}
