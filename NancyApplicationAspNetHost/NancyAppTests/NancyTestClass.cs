using CsQuery;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nancy;
using Nancy.Testing;
using NancyApplicationAspNetHost;

namespace NancyAppTests
{
    [TestClass]
    public class NancyTestClass
    {
        [TestMethod]
        public void Simplest_Get_Test()
        {
            var bootstrapper = new ConfigurableBootstrapper(with =>
            {
                with.Module<NancyFxModule>();
                with.RootPathProvider<TestRootPathProvider>();
            });

            //Act
            var browser = new Browser(bootstrapper);

            //Arrange
            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        } 
    }
}