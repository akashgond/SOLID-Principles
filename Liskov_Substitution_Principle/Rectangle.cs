using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    internal class Rectangle : Shape
    {
        public double length { get; set; }
        public double width { get; set; }
        public override double CalculateArea() => length * width;
      
    }
}
