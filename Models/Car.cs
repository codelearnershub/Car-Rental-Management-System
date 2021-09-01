                                                                                                                                                    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Models
{
    public class Car : BaseEntity
    {
        [Required]
        public string Make { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Year { get; set; }

        [Required]
        public string PlateNo { get; set; }

        [Required]
        public string Features { get; set; }
        [Required]
        public string BreakdownPrice { get; set; }
      
        public int LocationId { get; set; }
        [Required]
        public Location Location { get; set; }
       /* [Required]
        public string CarSn { get; set; }*/
        [Required]
      
        [DisplayName("Category")]
        public int CategoryId { get; set; }

        [Required]
        public decimal Price { get; set; }

        public byte[] InternalImage { get; set; }

        [DisplayName("Item Picture URL")]
        [StringLength(1024)]
        public string CarPictureUrl { get; set; }

        public virtual Category Category { get; set; }
        public List<Car_CarCategory> CarCarCategories{ get;  set; }
    }
}
