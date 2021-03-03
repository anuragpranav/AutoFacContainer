using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacContainer.Entities.Utilities
{
    public class LoggerModel : ILoggerModel
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging : " + message);
        }
    }
}
