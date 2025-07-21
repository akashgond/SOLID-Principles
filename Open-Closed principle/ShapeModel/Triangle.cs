using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_principle.ShapeModel
{
    internal class Triangle : Shapes
    {
        public double width { get; set; }

        public double height { get; set; }
        public override double CalculateArea()
        {
           return width * height*(1/2);
        }
    }
}
