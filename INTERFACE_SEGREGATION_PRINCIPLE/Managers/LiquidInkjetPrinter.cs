using INTERFACE_SEGREGATION_PRINCIPLE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE_SEGREGATION_PRINCIPLE.Managers
{
    public class LiquidInkjetPrinter : IPrinterTasks
    {

        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }

        

        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan Done");
        }
    }
}
