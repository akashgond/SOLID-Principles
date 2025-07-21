using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Responsiblity_principle
{
    internal class SendEmail
    {
        public void SendMail(string email, string message)
        {
            Console.WriteLine($"Email Sent to {email} : {message}");
        }
    }
}
