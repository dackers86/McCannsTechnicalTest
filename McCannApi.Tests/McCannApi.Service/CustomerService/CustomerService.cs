using McCannApi.Domain;
using McCannApi.Repository.CustomerRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCannApi.Service.CustomerService
{
    public class CustomerService : IHandleCustomers
    {
        private readonly IGetCustomerRepository _getCustomerRepository;
        public CustomerService(IGetCustomerRepository getCustomerRepository)
        {
            _getCustomerRepository = getCustomerRepository;
        }

        public List<Customer> GetAll()
        {
            return _getCustomerRepository.GetAll();
        }
    }
}
