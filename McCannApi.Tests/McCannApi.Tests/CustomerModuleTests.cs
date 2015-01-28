using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nancy;
using Nancy.Testing;
using Newtonsoft.Json;
using Moq;
using McCannApi.Api;
using System.Collections.Generic;
using McCannApi.Domain;
using McCannApi.Service.CustomerService;
using McCannApi.Repository.CustomerRepository;

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

        [TestMethod]
        public void WhenHTTPGetRequested_ItShouldReturnaListOfCustomers()
        {
            var customerService = new Mock<IHandleCustomers>();
            var bootstrapper = new DefaultNancyBootstrapper();
            var browser = new Browser(x => x.Module<CustomerModule>()
                                            .Dependency<IHandleCustomers>(customerService.Object));

            var response = browser.Get("/customer", with =>
            {
                with.HttpRequest();
                with.Header("Accept", "application/json");
            });

            customerService.Verify(x => x.GetAll(), Times.Once);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

        }
    }
}
