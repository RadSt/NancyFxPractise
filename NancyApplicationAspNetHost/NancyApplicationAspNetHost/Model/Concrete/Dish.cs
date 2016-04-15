using System.Collections.Generic;

namespace NancyApplicationAspNetHost.Model.Concrete
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSpicy { get; set; } 
        public List<Ingridients> Ingridients { get; set; } 
    }
}