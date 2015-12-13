using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Core.API.App_Start
{
    public class Bootstrapper
    {
        public static void Run(HttpConfiguration httpConfig)
        {
            // Configure Autofac
            AutofacWebapiConfig.Initialize(httpConfig);
        }
    }
}