using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace NancyApplicationAspNetHost.Model.Concrete
{
    public static class DishesRepository
    {
         public static List<Dish> Dishes = new List<Dish>
         {
             new Dish {Id=1, Name = "Porrige", IsSpicy = false},
             new Dish {Id = 2, Name = "Chili", IsSpicy = true},
             new Dish { Id = 3, Name = "Icecream", IsSpicy = false}
         };

        public static List<Dish> GetAllDishes()
        {
            return Dishes;
        }

        public static void AddDish(Dish dish)
        {
            Dishes.Add(dish);
        }
    }

}