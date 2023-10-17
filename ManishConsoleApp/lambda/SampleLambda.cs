using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.lambda
{
    public class SampleLambda
    {

        /**
         * Two type of lambda
         * Expression
         * (input-parameters) => expression
         * 
         * Statement
         * (input-parameters) => { <sequence-of-statements> }
         */

        public static void Main()
        {
            // Expression
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));

            // Statement
            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };
            greet("World");
           


        }
    }
}
