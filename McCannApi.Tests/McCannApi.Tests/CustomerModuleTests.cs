using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nancy;
using Nancy.Testing;
using Newtonsoft.Json;

namespace McCannApi.Tests
{
    [TestClass]
    public class CustomerModuleTests
    {
        [TestMethod]
        public void WhenHTTPGetRequested_ItShouldReturnStatus200()
        {
            var bootstrapper = new DefaultNancyBootstrapper();
            var browser = new Browser(bootstrapper);

            var response = browser.Get("customer/", with =>
            {
                with.HttpRequest();
                with.Header("Accept", "application/json");
            });

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
