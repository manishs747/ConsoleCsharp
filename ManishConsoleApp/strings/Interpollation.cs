using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.strings
{
    public class Interpollation
    {
        public static void Main()
        {
            int a = 100;
            float b = 250.0f;
            string c = "CSharp";

            Console.WriteLine("The values are {0}, {1}, {2}",a,b,c);
            Console.WriteLine($"The values are {a}, {b}, {c}");
            Console.WriteLine($"(a + b)/b is {(a + b)/b}");
            Console.WriteLine($"{c} in Upper-case is {c.ToUpper()}");
            Console.WriteLine($"Today is {DateTime.Now}");

        }

    }
}
