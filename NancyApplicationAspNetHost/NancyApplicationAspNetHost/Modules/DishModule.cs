using Nancy;
using NancyApplicationAspNetHost.Model.Concrete;

namespace NancyApplicationAspNetHost.Modules
{
    public class DishModule : NancyModule
    {
        public DishModule() : base("/Dish")
        {
            Post["/Add"] = ctx =>
            {
                var dish = new Dish {Id = Request.Form.Id, Name = Request.Form.Name, IsSpicy = Request.Form.IsSpicy};
                DishesRepository.AddDish(dish);
                return new Response {StatusCode = HttpStatusCode.Accepted};
            };

            Get["/GetALl"] = ctx => Response.AsJson(DishesRepository.GetAllDishes());
        }
    }
}