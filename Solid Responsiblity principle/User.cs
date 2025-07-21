using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Responsiblity_principle
{
    internal class User
    {
        //here the User class has two reasons to change 
        // 1.adding or modifying thr properties
        // 2.adding new methods or modifying the logic behind register

        public string UserName { get; set; }
        public string Password { get; set; }

        public string email  { get; set; }

        public void Register()
        {
            SendEmail sendEmail = new SendEmail();
            sendEmail.SendMail(email, "Mail sent successfully");
        }
    }
}
