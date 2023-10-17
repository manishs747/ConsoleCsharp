using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.control_loop
{
    public class Nullable
    {
        public static void Main()
        {
            string myString = null;

            // Access the variable only if it's not null
            string myNewString = myString?.ToUpper();

            // Use the null-coalescing operator to provide a default value if the variable is null
            string myOtherString = myString ?? "Default value";

            int? a = 28;
            int d = (int)(a != null ? -1 : a);
            int b = a ?? -1; //null-coalescing operator ??
            Console.WriteLine($"b is {b}");  // output: b is 28

            int? c = null;
            int e = c ?? -1;
            Console.WriteLine($"d is {d}");  // output: d is -1
        }


        static string? PadAndtrim(string input , int len , char padChar ) {
            return input?.Trim()?.PadLeft(len, padChar); 
            // it will return null when input is null
        }
    }
}
