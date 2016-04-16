using Nancy;

namespace NancyApplicationAspNetHost.Modules
{
    public class ViewModule : NancyModule
    {
        public ViewModule() : base("/views")
        {
            Get["/"] = param => View["View.html"];
        }
    }
}