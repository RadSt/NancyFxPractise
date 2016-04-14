using System.Collections.Generic;
using NancyApplicationAspNetHost.Model.Abstract;

namespace NancyApplicationAspNetHost.Model.Concrete
{
    public class Storage : IUserStorage
    {
        public IList<dynamic> GetAllUsers()
        {
            return new List<dynamic>
            {
                new {Name = "Homer", Age = 30},
                new {Name = "Bart", Age = 12},
                new {Name = "Marge", Age = 30},
                new {Name = "Lisa", Age = 10}
            };
        } 
    }
}