using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models.ViewModel
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public class CreateCategoryViewModel
    {[Required(ErrorMessage="fill this field")]
    [Display(Name="Category Name:")]
        public string Name { get; set; }
        public int Id { get; set; }
    }
    public class UpdateCategoryViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "fill this field")]
        [Display(Name = "Category Name:")]
        public string Name { get; set; }
    }
}
