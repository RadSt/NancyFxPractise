using System.Runtime.Remoting.Messaging;
using Nancy;

namespace NancyApplicationAspNetHost
{
    public class NancyFxModule : NancyModule
    {
        public NancyFxModule()
        {
            Get["/"] = param => View["Index.html"];

            Get["/{Name}"] = param =>
            {
                dynamic viewbag = new DynamicDictionary();
                viewbag.Name = param.Name;
                return View["Hello.html", viewbag];
            };
        }
    }
}