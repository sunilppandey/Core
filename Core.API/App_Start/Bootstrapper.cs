using Core.API.Mappings;
using System.Web.Http;

namespace Core.API.App_Start
{
    public class Bootstrapper
    {
        public static void Run(HttpConfiguration httpConfig)
        {
            // Configure Autofac
            AutofacWebapiConfig.Initialize(httpConfig);
            //Configure AutoMapper
            AutoMapperConfiguration.Configure();
        }
    }
}