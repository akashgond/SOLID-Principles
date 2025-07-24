using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
    //here The Car class uses IEngine to interact with different type of Engine 
    //Doesn't matter ehat  type of engine it is we will never have to make changesto Car class because of Engine 
    //this is an example of loose coupling
    internal class Car
    {
        public IEngine _engine;

        public Car(IEngine engine )  
        {
            _engine = engine;
        }

        public void StartCar()
        {
            _engine.Start();
            Console.WriteLine("Car has started");
        }
    }
}
