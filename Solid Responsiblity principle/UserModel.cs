using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Responsiblity_principle
{
    internal class UserModel
    {
        //It manages only properties
        public string UserName { get; set; }
        public string Password { get; set; }

        public string email { get; set; }
    }
}
