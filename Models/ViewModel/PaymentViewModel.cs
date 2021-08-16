using CarRentalsSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CarRentalsSystem.Models
{
    public class PaymentViewModel
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
      
        public Car Car { get; set; }
        public int CarId { get; set; }
        public string PaymentDate { get; set; }
        public Bookings Bookings { get; set; }
        public int BookingsId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public class CreatePaymentViewModel
    {
        public User User { get; set; }
        [Required(ErrorMessage="Fill this field")]
        [DisplayName("User Name")]
        public int UserId { get; set; }
        public Car Car { get; set; }
        [Required(ErrorMessage = "Fill this field")]
        [DisplayName("User Name")]
        public int CarId { get; set; }
        public string PaymentDate { get; set; }
        public Bookings Bookings { get; set; }
        [Required(ErrorMessage = "Fill this field")]
        [DisplayName("User Name")]
        public int BookingsId { get; set; }
        public int Id { get; set; }
    }
    public class UpdatePaymentViewModel
    {
        public User User { get; set; }
        [Required(ErrorMessage = "Fill this field")]
        [DisplayName("User Name")]
        public int UserId { get; set; }
        public Car Car { get; set; }
        [Required(ErrorMessage = "Fill this field")]
        [DisplayName("User Name")]
        public int CarId { get; set; }
        public string PaymentDate { get; set; }
        public Bookings Bookings { get; set; }
        [Required(ErrorMessage = "Fill this field")]
        [DisplayName("User Name")]
        public int BookingsId { get; set; }
        public int Id { get; set; }
    }
}