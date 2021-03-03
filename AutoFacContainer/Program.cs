using Autofac;
using DataAccessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacContainer //IOC Container - Builder to manage dependecies instead of class 
                           //| Dependency Inversion - Top level control lower
{
    class Program
    {
        static void Main(string[] args)
        {
            //BusinessLogic businessLogicObj = new BusinessLogic();
            //businessLogicObj.ProcessData();

            //Since we are using Atofac container, so above is commented.
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {

                var app = scope.Resolve<IApplication>();
                app.Run();
            
            }
            Console.ReadKey();
        }
    }
}
