using Open_Closed_principle.ShapeModel;

namespace Open_Closed_principle
{
  //Open-Closed principle - Software entities (claases, module, functions, etc.) should be open for extension but closed for modification
    internal class Program
    {
        static void Main(string[] args)
        {
            //Without Open-Closed principle

            //here BadShape class maanges both properties and methods 
            // in case we need to calculate area of new shape then will have to modify the badshape class
            //Go to implementation of BadShape class
            BadShape badShape = new BadShape();
            badShape.radius = 1;
            
            badShape.shapeType = ShapeType.Circle;
            var area = badShape.CalculateArea();
            Console.WriteLine("Area: "+ area);

            //With Open-Closed Principle

            //here an abstract class Shape is created having calculate method with is inherited by circle, rectangle and triangle
            //in future if new shape comes then we don't need to modify anything we can simply create a class for new shape and inherit the abstract class
            Circle circle = new Circle();
            circle.radius = 1;
           var areaofcircle = circle.CalculateArea();
            Console.WriteLine("Area: " + areaofcircle);



            Console.ReadLine();
        }
    }
}
