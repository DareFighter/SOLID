using SingleResponsibilityPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Managers
{
    public class Invoice
    {
        public long InvAmount { get; set; }
        public DateTime InvDate { get; set; }

        private ILogger fileLogger;

        private MailSender emailSender;

        public Invoice()
        {
            fileLogger = new Logger();
            emailSender = new MailSender();

        }

        public void AddInvoice()
        {
            try
            {
                fileLogger.Info("Add method start");
                //Here we need to write the Code for adding Invoice
                //Once the Invoice has been added, then send the mail
                emailSender.EmailFrom = "emailfrom@xyz.com";
                emailSender.EmailTo = "emailto@xyz.com";
                emailSender.EmailSubject = "single Responsibiliy Principle";
                emailSender.EmailBody = "A class should have only one reason to change";
                emailSender.SendEmail();
            }
            catch(Exception ex)
            {
                fileLogger.Error("Error Occured while Generating Invoice", ex);
            }
        }


        public void DeleteInvoice()
        {
            try
            {
                //here we need to write the code for deleting the already generated invoice
                fileLogger.Info("Delete Invoice starrt at @" + DateTime.Now);
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error Occured while deleting Invoice", ex);
            }
        }
    }
}
