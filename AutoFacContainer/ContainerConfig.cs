using Autofac;
using AutoFacContainer.Entities;
using AutoFacContainer.Entities.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacContainer
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            //Register Type.

            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(AutoFacContainer.Entities)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            //builder.RegisterType<DataAccessModel>().As<IDataAccessModel>();
            //builder.RegisterType<LoggerModel>().As<ILoggerModel>();

            builder.RegisterType<Application>().As<IApplication>();


            return builder.Build();
        }
    }
}
