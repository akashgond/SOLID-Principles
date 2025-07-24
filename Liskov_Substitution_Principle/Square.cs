using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    internal class Square : Shape
    {
        public double sideLength { get; set; }
        public override double CalculateArea()
        {
            return sideLength*sideLength;
        }
    }
}
