using McCannApi.Domain;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using McCannApi.Service.CustomerService;

namespace McCannApi.Api
{
    public class CustomerModule : NancyModule
    {
        public CustomerModule(IHandleCustomers customerService)
            : base("/customer")
        {
            Get["/"] = x =>
                {
                    return Response.AsJson<List<Customer>>(customerService.GetAll());
                };
        }
    }
}