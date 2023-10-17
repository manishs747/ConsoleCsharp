using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.event_delegates.del
{
    public class ActionSample
    {

        /**
         * 
         * an action is a delegate type that represents a method that
         * does not return a value but can take zero or more input parameters. 
         * It is similar to a function pointer in C or a lambda expression in C#.
         */

        static void Main()
        {
            // its inbuild delegate
            Action<string> printMessage = (message) => Console.WriteLine(message);
            printMessage("Hello, World!");

            /**
             * The Func delegate type takes one or more type parameters.
             * The first type parameter T represents the input parameter of the method,
             * and the last type parameter TResult represents the return type of the method.
             */

            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5)); // Output: 25
        }
    }
}
