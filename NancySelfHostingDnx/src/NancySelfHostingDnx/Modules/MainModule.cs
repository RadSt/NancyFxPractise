using System.Threading.Tasks;
using Nancy;

namespace NancySelfHostingDnx.Modules
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get[""] = (_, ctx) => Task.FromResult<dynamic>(View["index.html"]);
        }
    }
}