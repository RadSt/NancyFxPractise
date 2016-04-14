using Nancy;
using NancyApplicationAspNetHost.Model.Abstract;

namespace NancyApplicationAspNetHost.Modules
{
    public class UsersModule : NancyModule
    {
        public UsersModule(IUserStorage storage) : base("/users")
        {
            Get["/GetAll"] = param => Response.AsJson(storage.GetAllUsers());
        }
    }
}