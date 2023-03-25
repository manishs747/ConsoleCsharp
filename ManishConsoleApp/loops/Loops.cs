using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.loops
{
    public class Loops
    {

        public static void Main()
        {
            //whileloop();
            ForLoop();
            
        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"the for loop counter is {i}");
            }
        }

        private static void whileloop()
        {
            int counter = 0;
            while (counter++ < 10)
            {
                Console.WriteLine($"the counter is {counter}");
            }
        }
    }
}
