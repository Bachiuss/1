using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTry
{
    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car Engine started");
        }
    }
}
