using McCannApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCannApi.Service.CustomerService
{
    public interface IHandleCustomers
    {
       List<Customer> GetAll();
    }
}
