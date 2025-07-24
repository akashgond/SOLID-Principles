using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inerface_Segregation_principle
{
    internal class Sphere : IShape3D
    {
        public double radius { get; set; }

        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }
}
