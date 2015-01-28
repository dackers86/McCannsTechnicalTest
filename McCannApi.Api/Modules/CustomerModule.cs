using McCannApi.Domain;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace McCannApi.Api
{
    public class CustomerModule : NancyModule
    {
        public CustomerModule() : base("/customer")
        {
            Get["/"] = x =>
                {
                    return Response.AsJson<Customer>(new Customer { Id = 1 });
                };
        }
    }
}