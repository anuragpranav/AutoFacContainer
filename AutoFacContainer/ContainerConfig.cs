using Autofac;
using AutoFacContainer.Entities;
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

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(AutoFacContainer.Entities.Utilities)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));


            return builder.Build();
        }
    }
}
