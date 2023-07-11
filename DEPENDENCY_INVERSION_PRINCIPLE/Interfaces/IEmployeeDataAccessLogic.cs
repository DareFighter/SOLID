using DEPENDENCY_INVERSION_PRINCIPLE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPENDENCY_INVERSION_PRINCIPLE.Interfaces
{
    public interface IEmployeeDataAccessLogic
    {
        Employee GetEmployeeDetails(int id);
    }
}
