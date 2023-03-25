using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.strings
{
    public class Verbatim
    {
        public static void Main() {
            string filename1 = @"c:\documents\files\u0066.txt";
            string filename2 = "c:\\documents\\files\\u0066.txt";

            Console.WriteLine(filename1);
            Console.WriteLine(filename2);
            // The example displays the following output:
            //     c:\documents\files\u0066.txt
            //     c:\documents\files\u0066.txt


            string s1 = "He said, \"This is the last \u0063hance\x0021\"";
            string s2 = @"He said, ""This is the last \u0063hance\x0021""";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            // The example displays the following output:
            //     He said, "This is the last chance!"
            //     He said, "This is the last \u0063hance\x0021"
        }
    }
}
