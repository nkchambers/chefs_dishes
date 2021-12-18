using System.Collections.Generic;

namespace chefs_dishes.Models
{
    public class NewDishView 
    {
        public Dish Form { get; set; }
        public List<Chef> AvailableChefs { get; set; }
    }
}