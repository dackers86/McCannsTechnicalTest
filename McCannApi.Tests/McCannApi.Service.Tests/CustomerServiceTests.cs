using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using McCannApi.Repository.CustomerRepository;

namespace McCannApi.Service.Tests
{
    [TestClass]
    public class CustomerServiceTests
    {
        [TestMethod]
        public void WhenRequestingAllUsers_ItShouldReturnAllUsers()
        {
            var customerRepository = new Mock<IGetCustomerRepository>();
            var service = new CustomerService.CustomerService(customerRepository.Object);

            customerRepository.Setup(x => x.GetAll());

            service.GetAll();
            customerRepository.Verify(x => x.GetAll());
        }
    }
}
