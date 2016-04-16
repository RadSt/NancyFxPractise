using Nancy;

namespace NancySelfHosting.Modules
{
    public class NancyFxModule : NancyModule
    {
        public NancyFxModule()
        {
            Get["/"] = param => "I'm Nansy Self Host Application.";
        }
    }
}