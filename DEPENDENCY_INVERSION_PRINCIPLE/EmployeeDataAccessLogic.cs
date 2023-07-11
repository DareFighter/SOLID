using DEPENDENCY_INVERSION_PRINCIPLE.Interfaces;
using DEPENDENCY_INVERSION_PRINCIPLE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPENDENCY_INVERSION_PRINCIPLE
{
    public class EmployeeDataAccessLogic: IEmployeeDataAccessLogic
    {
        public Employee GetEmployeeDetails(int id)
        {

            //In real time get the emploee details from database
            //but here we have hard coded the employee

            Employee emp = new Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }
}
