using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
    internal class BadEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine is started");
        }
    }
}
