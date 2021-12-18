using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace chefs_dishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }


        [Display(Name = "First Name")]
        [Required(ErrorMessage ="First Name of Chef required.")]
        [MinLength(2, ErrorMessage = "Chef's first name must be at least 2 character long.")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [Required(ErrorMessage ="Last Name of Chef required.")]
        [MinLength(2, ErrorMessage = "Chef's last name must be at least 2 character long.")]
        public string LastName { get; set; }


        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Date of Birth required.")]
        public DateTime DateOfBirth { get; set; }

        //Navigation property for dishes created by this Chef
        public List<Dish> DishesCreated { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


    }
}