using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace McCannApi.Api.Modules
{
    public class BaseModule : NancyModule
    {
        public BaseModule()
        {
            Get["/"] = x =>
                {
                    return HttpStatusCode.Forbidden;
                };
        }
    }
}