using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacContainer.Entities.Utilities
{
    public class DataAccessModel : IDataAccessModel
    {
        public void AccessData(string request)
        {
            Console.WriteLine("Access : " + request);
        }
    }
}
