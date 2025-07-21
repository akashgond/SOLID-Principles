using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_principle
{
    internal class BadShape
    {
        //Badshape voilates Solid responsibility principle as it manages both properties and methods 
        //in case we need to calculate area of triangle then we need to modify both shapetype enum and the Calculate method 
        public double length { get; set; }
        public double width { get; set; }
        public ShapeType shapeType { get; set; }
        public double radius { get; set; }

        public double CalculateArea()
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                    {
                        return Math.PI * Math.Pow(radius, 2);
                    } 
                    break;
                 case ShapeType.Rectangle:
                    {
                        return length * width;
                    }
                    break;
                    default: throw new InvalidDataException("shape does not exist");
            }
        }
    }
}
