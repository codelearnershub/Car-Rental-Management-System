using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models.ViewModel
{
    public class BookingViewModel
    {
		public int Id { get; set; }
		public string FirstName { get; set; }		
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string PhoneNo { get; set; }
		public string Gender { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Booking_ref { get; set; }
		public int Customer_Id { get; set; }
		public string CustomerName { get; set; }
		public int Car_Id { get; set; }
		public string CarName { get; set; }
		public int Location_Id { get; set; }
		public string Location { get; set; }
		public DateTime Booking_Date { get; set; }
		public DateTime Return_Date { get; set; }
		public DateTime CreatedAt { get; set; }
	}
	public class CreateBookingsViewModel
    {
		[Required(ErrorMessage="This field has to be filled")]
		[Display(Name="Booking ref No")]
		public string Booking_ref { get; set; }
		[Required(ErrorMessage = "This field has to be filled")]
		[Display(Name = "Customer Name")]
		public int Customer_Id { get; set; }
		[Required(ErrorMessage = "This field has to be filled")]
		[Display(Name = "Car Booked")]
		
		public int Car_Id { get; set; }
		[Required(ErrorMessage = "This field has to be filled")]
		[Display(Name = "Car ")]
		public Car Car { get; set; }
		public int Location_Id { get; set; }
		[Required(ErrorMessage = "This field has to be filled")]
		[Display(Name = "Location")]
		public Location Location { get; set; }
		public DateTime Booking_Date { get; set; }
		[Required(ErrorMessage = "This field has to be filled")]
		[Display(Name = "Booking Date")]
		public DateTime Return_Date { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public string FirstName { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public string MiddleName { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public string LastName { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public DateTime DateOfBirth { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public string PhoneNo { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public string Gender { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public string CustomerAddress { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public string Password { get; set; }
		public DateTime CreatedAt { get; set; }
        public int UserId { get; internal set; }
    }
	public class UpdateBookingsViewModel
    { public int Id { get; set; }
		[Required(ErrorMessage = "This field has to be filled")]
		[Display(Name = "Booking ref No")]
		public string Booking_ref { get; set; }
		[Required(ErrorMessage = "This field has to be filled")]
		[Display(Name = "Customer Name")]
		public int Customer_Id { get; set; }
		[Required(ErrorMessage = "This field has to be filled")]
		[Display(Name = "Car Booked")]
		public User User { get; set; }
		public int Car_Id { get; set; }
		
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public string FirstName { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public string MiddleName { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public string LastName { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public DateTime DateOfBirth { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public string PhoneNo { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public string Gender { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public string CustomerAddress { get; set; }
		[Required(ErrorMessage = "Fill this field")]
		[Display(Name = "FirstName")]
		public string Password { get; set; }
		[Display(Name = "Booking Location")]
		public Car Car { get; set; }
		public int Location_Id { get; set; }
		[Required(ErrorMessage = "This field has to be filled")]
		[Display(Name = "Booking Date")]
		public Location Location { get; set; }
		public DateTime Booking_Date { get; set; }
		[Required(ErrorMessage = "This field has to be filled")]
		[Display(Name = "Booking Date")]
		public DateTime Return_Date { get; set; }
	}
	
}
