using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPENDENCY_INVERSION_PRINCIPLE
{
    public class DataAccessFactory
    {
        public static EmployeeDataAccessLogic GetEmployeeDataAccessLogic()
        {
            return new EmployeeDataAccessLogic();
        }
    }
}
