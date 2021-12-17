using System.Collections.Generic;

namespace chefs_dishes.Models
{
    public class IndexView 
    {
        public List<Chef> AllChefs { get; set; }
        public List<Dish> AllDishes { get; set; }
    }
}