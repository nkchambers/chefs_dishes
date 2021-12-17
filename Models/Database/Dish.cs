using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chefs_dishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }


        [Display(Name = "Name of Dish")]
        [Required(ErrorMessage ="Please provide a name for your new dish.")]
        [MinLength(1, ErrorMessage = "Your new dish's name must be at least 1 character long.")]
        public string DishName { get; set; }


        [Display(Name = "Tastiness Level (Rate on Scale 1-5)")]
        [Required(ErrorMessage ="Please select a tastienss level (1-5).")]
        [Range(1, 5)]
        public int? Tastiness { get; set; }
        
        
        [Display(Name = "# of Calories")]
        [Required(ErrorMessage ="Calories must be greater than 1.")]
        [Range(1,  Int32.MaxValue)]
        public int? Calories { get; set; }


        [Display(Name = "Description")]
        [Required(ErrorMessage ="Please provide a description for your new dish.")]
        [MinLength(3, ErrorMessage = "Dish's description must be at least 3 characters long.")]
        public string Description { get; set; }

        //Foreign Key for the Chef that created the dish
        [Display(Name = "Created By: ")]
        public int ChefId { get; set; }
        
        //Navigation property for that actual Chef
        public Chef CreatedBy { get; set; }

        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        //This property is exclusivley for our form
        [Display(Name ="Chef")]
        [Required(ErrorMessage = "Please select the chef who created the dish.")]
        [NotMapped]
        public List<Chef> AvailableChefs { get; set; }

    }
}
