using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using NancyApplicationAspNetHost.Model.Abstract;
using NancyApplicationAspNetHost.Model.Concrete;

namespace NancyApplicationAspNetHost
{
    public class MyBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);
            container.Register<IUserStorage, SouthParkUsers>();
        }
    }
}