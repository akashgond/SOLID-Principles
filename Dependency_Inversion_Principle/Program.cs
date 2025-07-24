namespace Dependency_Inversion_Principle
{
    //Dependency Inversion Principle - High-level modules should not depend on low-level modules
    //-Both should depend on  abstraction or Interfaces
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example Violating Dependency Inversion principle

            var car = new BadCar();
            car.StartCar();

            //here BadCar is dependent on Engine class 
            //if we modify the implementation of Engine class it will impact BadCar class and hence will have to do modification there also 
            //In case we have different  engine types like Electric,v8,inline etc.. then we will have  to modify BadCar class every time we have a different Engine


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Example which follows Dependency Inversion principle

            var car1 = new Car(new InlineEngine());
            car1.StartCar();

            //here the dependency of Engine has been removed by implementing IEngine interface
            //Doesn't matter what type of engine it is  we can add as many as we want without doing any changes to Car class





            Console.ReadLine();
        }
    }
}
