namespace Inerface_Segregation_principle
{
    //Interface Segregation principle (ISP)- Clients should not be forced to depend on interfaces they do not use
    //Note : Clients means all the classes which are consuming these interfaces
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example which violates Interface Segregation Principle

            try
            {
                var circle = new BadCircle();
                circle.radius = 5;
                Console.WriteLine($"Area of Circle is : {circle.area()}");
                Console.WriteLine($"Volume of Circle is : {circle.Volume()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }

            //This will give error as Circles do not have any Volume its a 2D shape and IShape forces Circle to implement Volume method also
            //This violates the ISP

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Example which follows the Interface Segregation Principle

            var circle1 = new Circle();
            circle1.radius = 5;
            Console.WriteLine($"Area of Circle is : {circle1.Area()}");

            var sphere = new Sphere();
            sphere.radius = 5;
            Console.WriteLine($"Area of Sphere is : {sphere.Area()}");
            Console.WriteLine($"Volume of Sphere is : {sphere.Volume()}");

            //here if you see for 2D and 3D shapes we have two different interfaces which can be used depending upon shapes 
            //and in this way the classes will not be forced to implement things from interface which they do not use




            Console.ReadLine();
        }
    }
}
