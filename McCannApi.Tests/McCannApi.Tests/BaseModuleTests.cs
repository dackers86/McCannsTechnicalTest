using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nancy;
using Nancy.Testing;
using McCannApi.Api.Modules;

namespace McCannApi.Tests
{
    [TestClass]
    public class BaseModuleTests
    {
        [TestMethod]
        public void WhenHTTPBaseRouteRequested_ItShouldReturnStatus403()
        {
            var browser = new Browser(x => x.Module<BaseModule>());

            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            Assert.AreEqual(HttpStatusCode.Forbidden, result.StatusCode);
        }
    }
}
