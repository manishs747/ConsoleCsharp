using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.extention
{
    public static class StringExtensions
    {
        public static void Main ()
        {
            string myString = "racecar";
            bool isPalindrome = myString.IsPalindrome(); // returns true

        }

        /*
         * Extenstion method be static, and 
         * the first parameter must be of the type you are extending
         */
        public static bool IsPalindrome(this string input)
        {
            string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}
