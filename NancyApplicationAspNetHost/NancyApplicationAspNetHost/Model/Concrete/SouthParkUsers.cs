using System.Collections.Generic;
using NancyApplicationAspNetHost.Model.Abstract;

namespace NancyApplicationAspNetHost.Model.Concrete
{
    public class SouthParkUsers : IUserStorage
    {
        public IList<dynamic> GetAllUsers()
        {
            return new List<dynamic>
            {
                new {Name ="Erik", SeccondName="Cartman", Age = 9},
                new {Name = "Kenny", SecondName="McCormic", Age = 9},
                new {Name = "Kyle", SecondName = "Broflovski", Age = 9},
                new {Name = "Stan", SecondName = "March", Age = 9},
                new {Name = "Butters", SecondName = "Stotch", Age = 9}
            };
        } 
    }
}