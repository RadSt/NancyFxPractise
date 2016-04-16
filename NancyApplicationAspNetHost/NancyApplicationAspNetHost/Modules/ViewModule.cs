using System.Collections.Generic;
using Nancy;
using NancyApplicationAspNetHost.Model.Concrete;

namespace NancyApplicationAspNetHost.Modules
{
    public class ViewModule : NancyModule
    {
        public ViewModule() : base("/views")
        {
            Get["/"] = param =>
            {
                List<Dish> dishes = DishesRepository.GetAllDishes();
                return View["View.html", dishes];
            };
        }
    }
}