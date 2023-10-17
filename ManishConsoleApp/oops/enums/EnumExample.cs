using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.oops.enums
{
    public class EnumExample
    {

        public static void Main(string[] args)
        {
            DaysOfWeek today = DaysOfWeek.Tuesday;
            Console.WriteLine(today);
            switch (today)
            {
                case DaysOfWeek.Monday:
                    Console.WriteLine("Today is Monday.");
                    break;
                case DaysOfWeek.Tuesday:
                    Console.WriteLine("Today is Tuesday.");
                    break;
                // ...
                default:
                    Console.WriteLine("Invalid day of the week.");
                    break;
            }



        }
    }
}
