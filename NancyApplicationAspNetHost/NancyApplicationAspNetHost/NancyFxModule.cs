using Nancy;

namespace NancyApplicationAspNetHost
{
    public class NancyFxModule : NancyModule
    {
        public NancyFxModule()
        {
            Get["/"] = param => View["Index.html"];
        }
    }
}