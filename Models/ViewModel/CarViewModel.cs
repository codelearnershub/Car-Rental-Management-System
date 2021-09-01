using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CarRentalsSystem.Models.ViewModel
{
    public class CarViewModel
    {
        public int Id { get; set; }      
        public string Make { get; set; }     
        public string Name { get; set; }      
        public string Model { get; set; }       
        public string PlateNo { get; set; }      
        public string Features { get; set; } 
        public string BreakdownPrice { get; set; }      
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int CategoryId { get; set; }      
        public decimal Price { get; set; }
        public byte[] InternalImage { get; set; }
        public string CarPictureUrl { get; set; }
        public virtual Category Category { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public class CreateCarViewModel
    {
        [Required(ErrorMessage = "A Car Make is required")]
        public string Make { get; set; }
        [Required(ErrorMessage = "A Car Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "An Car Model is required")]
        public string Year { get; set; }
        [Required(ErrorMessage = "An Car Plate No is required")]
        public string PlateNo { get; set; }
        [Required(ErrorMessage = "An Car Features is required")]
        public string Features { get; set; }
        [Required(ErrorMessage = "An Car Break down Price is required")]
        public string BreakdownPrice { get; set; }
        [DisplayName("Location")]
        public int LocationId { get; set; }
        [Required]
        public Location Location { get; set; }
        [Required]

        [DisplayName("Category")]
        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> LocationList { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        public byte[] InternalImage { get; set; }

        [DisplayName("Item Picture URL")]
        [StringLength(1024)]
        public string CarPictureUrl { get; set; }

        public virtual Category Category { get; set; }
    }

    public class UpdateCarViewModel
    {
        [Required(ErrorMessage = "A Car Make is required")]
        public string Make { get; set; }
        [Required(ErrorMessage = "A Car Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "An Car Model is required")]
        public string Model { get; set; }
        [Required(ErrorMessage = "An Car Plate No is required")]
        public string PlateNo { get; set; }
        [Required(ErrorMessage = "An Car Features is required")]
        public string Features { get; set; }
        [Required(ErrorMessage = "An Car Break down Price is required")]
        public string BreakdownPrice { get; set; }
        [DisplayName("Location")]
        public int LocationId { get; set; }
        [Required]
        public Location Location { get; set; }
        [Required]

        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        public byte[] InternalImage { get; set; }

        [DisplayName("Item Picture URL")]
        [StringLength(1024)]
        public string CarPictureUrl { get; set; }

        public virtual Category Category { get; set; }
    }

}

