using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.control_loop
{
    public class Switch
    {

        public static void Main()
        {
            int value = 2;
            Console.WriteLine(SwitchMethod(value));
            Console.WriteLine(SwitchExpression(value));
        }


        private static string SwitchMethod(int value)
        {
            string result;
            switch (value)
            {
                case 0:
                case 1:
                    result = "One";
                    break;
                case 2:
                    result = "Two";
                    break;
                case 3:
                    result = "Three";
                    break;
                default:
                    result = "Other";
                    break;
            }
            return result;
        }

        private static string SwitchExpression(int value)
        {
            return value switch
            {
                0 or 1 => "One",
                2 => "Two",
                3 => "Three",
                _ => "Other",
            }; 
        }

       
    }
}
