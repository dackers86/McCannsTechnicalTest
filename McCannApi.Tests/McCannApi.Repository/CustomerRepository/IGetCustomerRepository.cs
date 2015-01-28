using McCannApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCannApi.Repository.CustomerRepository
{
    public interface IGetCustomerRepository
    {
        List<Customer> GetAll();
    }
}
