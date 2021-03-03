using AutoFacContainer.Entities.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacContainer.Entities
{
    public class BusinessLogic : IBusinessLogic
    {
        ILoggerModel _logObject;
        IDataAccessModel _dataAccessModel;

        public BusinessLogic(ILoggerModel logObject, IDataAccessModel dataAccessModel)
        {
            _logObject = logObject;
            _dataAccessModel = dataAccessModel;
        }

        public void ProcessData()
        {
            _logObject.Log("Started logging process.");
            _dataAccessModel.AccessData("Started Connection.");

            Console.WriteLine("Business logic implemented.");

            _dataAccessModel.AccessData("Ended Connection.");
            _logObject.Log("Ended logging process.");
        }
    }
}
