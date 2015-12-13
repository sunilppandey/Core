using Autofac;
using Autofac.Integration.WebApi;
using Core.Data;
using Core.Data.Repositories;
using Core.Infrastructure;
using Core.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace Core.API.App_Start
{
    public class AutofacWebapiConfig
    {
        public static IContainer Container;
        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            //GlobalConfiguration.Configuration.DependencyResolver = config.DependencyResolver;
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // EF ApplicationDbContext
            builder.RegisterType<ApplicationDbContext>()
                   .As<DbContext>()
                   .InstancePerRequest();

            builder.RegisterType<EFUnitOfWorkFactory>()
                .As<IUnitOfWorkFactory>()
                .InstancePerRequest();

            builder.RegisterType<EFUnitOfWork>()
                .As<IUnitOfWork>()
                .InstancePerRequest();

            builder.RegisterType<BookRepository>()
                .As<IBookRepository>()
                .InstancePerRequest();

            //builder.RegisterGeneric(typeof(Repository<>))
            //       .As(typeof(IRepository<BookRepository, int>))
            //       .InstancePerRequest();

            // Services

            // Generic Data Repository Factory
            //builder.RegisterType<DataRepositoryFactory>()
            //    .As<IDataRepositoryFactory>().InstancePerRequest();

            Container = builder.Build();

            return Container;
        }
    }
}