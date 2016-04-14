using System.Collections.Generic;

namespace NancyApplicationAspNetHost.Model.Abstract
{
    public interface IUserStorage
    {
        IList<dynamic> GetAllUsers();
    }
}