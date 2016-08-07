namespace geogo.api
{
    using Autofac;
    using Autofac.Integration.Mvc;
    using Autofac.Integration.WebApi;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Web;
    using System.Web.Http;
    using geogo.data;
    using geogo.data.Dbcontext;
    using geogo.data.Interface;
    using geogo.service.Service;
    using System.Web.Mvc;

    public class AutoBootstrapper
    {
        public static void Run()
        {

            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            // Autofac
            builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).InstancePerRequest();
            builder.RegisterWebApiFilterProvider(config);

            // register db context
            builder.RegisterType<geogocontext>().As<Igeogocontext>()
                .WithParameter("connectionString", "geogocontext").InstancePerLifetimeScope();
            // regiter service
            builder.RegisterType<DBAccessService>().AsImplementedInterfaces().InstancePerDependency();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

    }
}