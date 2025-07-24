using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
    //here InlineEngine implments IEngine interface 
    internal class InlineEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine is started");
        }
    }
}
