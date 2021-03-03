using AutoFacContainer.Entities.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacContainer.Entities
{
    public class BusinessLogic
    {
        LoggerModel logObject = new LoggerModel();
        DataAccessModel dataAccessModel = new DataAccessModel();

        public BusinessLogic()
        {
          
        }

        public void ProcessData()
        {
            logObject.Log("Started logging process.");
            dataAccessModel.AccessData("Started Connection.");

            Console.WriteLine("Business logic implemented.");

            dataAccessModel.AccessData("Ended Connection.");
            logObject.Log("Ended logging process.");
        }
    }
}
