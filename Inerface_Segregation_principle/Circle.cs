using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inerface_Segregation_principle
{
    internal class Circle : IShape2D
    {
        public double radius { get; set; }

        public double Area()
        {
           return Math.PI * Math.Pow(radius, 2);
        }
    }
}
