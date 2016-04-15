namespace NancyApplicationAspNetHost.Modules
{
    public class RouteModule : NancyFxModule
    {
        public RouteModule()
        {
            Get["/client"] = p => "Hello API user!";
            Get["/client"] = p => View["Index.html"];
        }
    }
}