using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_principle.ShapeModel
{
    internal class Rectangle : Shapes
    {
        public double length { get; set; }

        public double width { get; set; }
        public override double CalculateArea()
        {
            return length*width;
        }
    }
}
