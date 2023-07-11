using INTERFACE_SEGREGATION_PRINCIPLE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE_SEGREGATION_PRINCIPLE.Managers
{
    public class HPLaserJetPrinter : IPrinterTasks , IFaxTasks, IPrintDuplexTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print done");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }

        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax Content");
        }

        public void PrintDuplex(string PrintDuplex)
        {
            Console.WriteLine("Print Duplex content");
        }
    }
}
