using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Responsiblity_principle
{
    internal class UserService
    {
       //It maanges only Register method
        public void Register(string email)
        {
            SendEmail sendEmail = new SendEmail();
            sendEmail.SendMail(email, "Mail sent successfully");
        }
    }
}
