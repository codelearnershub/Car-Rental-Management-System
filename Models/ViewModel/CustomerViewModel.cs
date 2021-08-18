using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models.ViewModel
{
    public class CustomerViewModel
    {
        public User User { get; set; }
        public int UserId { get; set; }
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
        [Required]
        public string CardNo { get; set; }
        [Required]
        public int CardPin { get; set; }
    }
    public class CreateCustomerViewModel
    {[Required(ErrorMessage="fill out this field")]
    [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "fill out this field")]
        [Display(Name = "Password")]
        public string PasswordHash { get; set; }
        [Required(ErrorMessage = "fill out this field")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "fill out this field")]
        [Display(Name = "Email")]
        public string HashSalt { get; set; }
        [Required(ErrorMessage = "fill out this field")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "fill out this field")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "fill out this field")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "fill out this field")]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "fill out this field")]
        [Display(Name = "Phone No")]
        public string PhoneNo { get; set; }
        [Required(ErrorMessage = "fill out this field")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "fill out this field")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "fill out this field")]
        [Display(Name = "Card No")]
        public string CardNo { get; set; }
        [Required(ErrorMessage = "fill out this field")]
        [Display(Name = "CardPin")]
        public int CardPin { get; set; }
        public User User { get; set; }
        [Required(ErrorMessage = "fill out this field")]
        [Display(Name = "User")]
        public int UserId { get; set; }
    }
}
