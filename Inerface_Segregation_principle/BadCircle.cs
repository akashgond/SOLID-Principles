using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Inerface_Segregation_principle
{
    internal class BadCircle : IShape
    {
        //here circle has to inherit both Area and Volume methods from the interface
        public double radius { get; set; }
        public double area()
        {
            return Math.PI * Math.Pow(radius,2);
        }

        public double Volume()
        {
            throw new InvalidOperationException("Circle does not have volume");
        }
    }
}
