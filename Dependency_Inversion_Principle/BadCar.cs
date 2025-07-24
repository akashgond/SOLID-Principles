using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{

    //here the BadCar class (High-level) is dependent on Engine class (Low-level) also also forms tight coupling
    internal class BadCar
    {
        public BadEngine engine;

        public BadCar()
        {
            this.engine = new BadEngine();
        }

        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car has started");
        }
    }
}
