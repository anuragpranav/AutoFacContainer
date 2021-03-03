using DataAccessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacContainer
{
    public class Application
    {
        IBusinessLogic _businessLogicObj;
        public Application(IBusinessLogic businessLogicObj)
        {
            _businessLogicObj = businessLogicObj;
        }

        public void Run()
        {

            _businessLogicObj.ProcessData();
        }
    }
}
