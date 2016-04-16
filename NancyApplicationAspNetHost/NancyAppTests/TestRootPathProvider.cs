using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nancy;

namespace NancyAppTests
{
    public class TestRootPathProvider : IRootPathProvider
    {
        public string GetRootPath()
        {
            return @"D:\GIT\NancyFxPractise\NancyApplicationAspNetHost\NancyApplicationAspNetHost";
        }
    }
}
