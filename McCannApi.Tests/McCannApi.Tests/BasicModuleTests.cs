using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nancy;
using Nancy.Testing;

namespace McCannApi.Tests
{
    [TestClass]
    public class BasicModuleTests
    {
        [TestMethod]
        public void WhenHTTPBaseRouteRequested_ItShouldReturnStatus403()
        {
            var bootstrapper = new DefaultNancyBootstrapper();
            var browser = new Browser(bootstrapper);

            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            Assert.AreEqual(HttpStatusCode.Forbidden, result.StatusCode);
        }
    }
}
