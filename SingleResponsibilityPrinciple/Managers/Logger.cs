using SingleResponsibilityPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Managers
{
    public class Logger : ILogger
    {

        public Logger()
        {
            //here we need to write the code for initialization
            //that is Creating the Log file with necessary details
        }
        public void Debug(string info)
        {
            //here we need to write the code for Degub Information into the ErrorLog text File
            throw new NotImplementedException();
        }

        public void Error(string message, Exception ex)
        {
            //here we need to write the Code for Error information into the ErrorLog text file
            throw new NotImplementedException();
        }

        public void Info(string info)
        {
            //here we need to the code for info information into the ErrorLog text file
            throw new NotImplementedException();
        }
    }
}
