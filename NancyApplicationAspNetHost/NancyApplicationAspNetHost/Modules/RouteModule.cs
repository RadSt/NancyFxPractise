using System;
using Nancy;

namespace NancyApplicationAspNetHost.Modules
{
    public class RouteModule : NancyFxModule
    {
        private readonly Func<Request, bool> _isNotApiClient = request => 
        !request.Headers.UserAgent.Equals("Fiddler"); 
        public RouteModule()
        {
            Get["/client"] = p => "Hello API user!";
            Get["/client", context => _isNotApiClient(context.Request)] = p => View["Index.html"];
        }
    }
}