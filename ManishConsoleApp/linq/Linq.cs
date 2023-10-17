using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.linq
{
    public class Linq
    {

        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}
