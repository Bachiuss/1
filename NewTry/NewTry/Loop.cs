using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTry
{
    public class Loop
    {
        int age = 21;
        string Name = "Bachana";

        public void ForLoop()
        {
            for (int i = 1; i <= 10; ++i)
            {
                Console.WriteLine("My name is" + Name + " and current index is " + i);
            }
        }
    }
}
