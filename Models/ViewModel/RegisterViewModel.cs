using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models.ViewModel
{
    public class RegisterViewModel:LoginViewModel
    {[Required(ErrorMessage="Fill out this field")]
    [Display(Name ="First Name")]
        public string FirstName { get; set; }
       [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Register As")]
        public int UserType { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Phone No")]
        public string PhoneNo { get;  set; }
        [Required(ErrorMessage = "Fill out this field")]
        [Display(Name = "Address")]
        public string Address { get;set; }
        public List<Role> Roles { get; set; }
        public int Id { get; internal set; }
        public string ConfirmPassword { get; internal set; }
        public string PasswordHash { get; internal set; }
    }
}
