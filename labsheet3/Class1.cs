using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet3
{
    class Program

    {
        static void Main(string[] args)
        {

            Car c1 = new Car();
            c1.Make = "Ford";
            c1.Model = "Focus";
            c1.CurrentSpeed = 0;
            c1.EngineSize = 1.6;

            Car c2 = new Car();
            c2.Make = "Ope1";
            c2.Model = "Astra";
            c2.CurrentSpeed = 0;
            c2.EngineSize = 1.2;

            Console.WriteLine($" The {c1.Make}{c1.Model} , engine size {c1.EngineSize} 1 is currentlytravelling at {c1.CurrentSpeed} km/h");

            Console.WriteLine($" The {c2.Make}{c2.Model} , engine size {c2.EngineSize} 1 is currentlytravelling at {c2.CurrentSpeed} km/h");
        }
    }
}
