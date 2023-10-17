using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.NewFolder
{
    public class NullReference
    {
        public NullReference() { }

        //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-reference-types
        public static void Main()
        {


            int? a = 28;
            int b = a ?? -1;
            Console.WriteLine($"b is {b}");  // output: b is 28

            int? c = null;
            int d = c ?? -1;
            d = c.GetValueOrDefault(); //above line is same
            Console.WriteLine($"d is {d}");  // output: d is -1

        }



    }
}
