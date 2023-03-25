using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.strings
{
    public class Manipulation
    {

        public static void Main()
        {
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";
            string str4 = "This is a string";
            string[] strs = { "one", "two", "three", "four" };

          
            Console.WriteLine(str2.Equals(str4));
            Console.WriteLine(str2 == str4);

            // Access individual characters
            Console.WriteLine($"Character at 14th index is {str1[14]}");

            // Iterate over a string like any other sequence of values
            foreach (char ch in str1)
            {
                Console.Write(ch);
                if (ch == 'b')
                {
                    Console.WriteLine();
                    break;
                }
            }

            // String Concatenation         
            string outstr;
            outstr = string.Concat(strs);
            Console.WriteLine(outstr);

            // Joining strings together with Join
            outstr = string.Join('.', strs);
            Console.WriteLine(outstr);
            outstr = String.Join("---", strs);
            Console.WriteLine(outstr);

            // String Comparison

            // Equals just returns a regular Boolean
            bool isEqual = str2.Equals(str3);
            Console.WriteLine($"{isEqual}");

            // Compare will perform an ordinal comparison and return:
            // < 0 : first string comes before second in sort order
            // 0 : first and second strings are same position in sort order
            // > 0 : first string comes after the second in sort order
            int result = String.Compare(str2, "This is a string");
            Console.WriteLine($"{result}");

            // Replacing content
            outstr = str1.Replace("fox", "cat");
            Console.WriteLine($"{outstr}");

        }
    }
}
