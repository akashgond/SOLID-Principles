namespace Liskov_Substitution_Principle
{
    internal class Program
    {
        //Liskov Substitution Principle - Objects of its superclass should be replaceable with objects  of its sub-class without
        //affecting the correctness of the program

        static void Main(string[] args)
        {
            //Example which voilates Liskov Substitution Principle

            //Example 1 calling rectangle class 

            var rec = new Rectangle();
            rec.length = 10;
            rec.width = 5;
            Console.WriteLine($"Area of rectangle is {rec.CalculateArea()}");

            //Till now we are able to calculate the area of rectangle
            
            //Example 2 Calling Square class
            var sq= new BadSquare();
            sq.width = 5;
            sq.height = 5;
            Console.WriteLine($"Area of rectangle is {sq.CalculateArea()}");

            //Example 3 calculating area of rectangle using Square class because as per LSP 
            //objects of superclass can be replaced with objects of subclass

            var rec1 = new BadSquare();
            rec1.height = 10;
            rec1.width = 5;
            Console.WriteLine($"Area of rectangle is {rec1.CalculateArea()}");

            // here the area of rectangle comes 25 which is wrong it should be 50 which  is affecting our program and voilating LSP

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //Example which Liskov Substitution Principle

            //Example 1 calling rectangle class 

            var rec2 = new Rectangle();
            rec.length = 10;
            rec.width = 5;
            Console.WriteLine($"Area of rectangle is {rec.CalculateArea()}");

            //Example 2 Calling Square class
            var sq1 = new BadSquare();
            sq.width = 5;
            sq.height = 5;
            Console.WriteLine($"Area of rectangle is {sq.CalculateArea()}");

            //here both the classes inherit the abstract class Shape and are calculating area based upon the shape without any issues

            Console.ReadLine();
        }
    }
}
