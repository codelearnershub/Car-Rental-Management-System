 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models
{
    public class User: BaseEntity
    {
        [Required]
        public string PasswordHash { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        [Required]
        public string HashSalt { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public Admin Admin { get; set; }
        public int AdminId { get; set; }
    }
}
