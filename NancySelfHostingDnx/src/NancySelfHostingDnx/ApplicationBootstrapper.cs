﻿using System;
using Microsoft.Extensions.PlatformAbstractions;
using Nancy;
using Nancy.Conventions;
using Nancy.TinyIoc;

namespace NancySelfHostingDnx
{
    public class ApplicationBootstrapper : DefaultNancyBootstrapper
    {
        protected override IRootPathProvider RootPathProvider => ApplicationContainer.Resolve<IRootPathProvider>();

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            container.Register<IRootPathProvider, ApplicationEnvironmentRootPathProvider>();
            base.ConfigureApplicationContainer(container);
        }

        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            nancyConventions.StaticContentsConventions.Clear();
            nancyConventions.StaticContentsConventions
                .Add(StaticContentConventionBuilder.AddDirectory("/","wwwroot"));
            base.ConfigureConventions(nancyConventions);
        }
    }

    public class ApplicationEnvironmentRootPathProvider : IRootPathProvider
    {
        public string GetRootPath()
        {
            return PlatformServices.Default.Application.ApplicationBasePath;
        }
    }
}