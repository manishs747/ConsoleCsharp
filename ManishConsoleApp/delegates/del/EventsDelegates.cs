using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.event_delegates.del
{
    public class EventsDelegates
    {

        public static void Main()
        {

            EventsDelegates eventsDelegates = new EventsDelegates();
            PassMeWork(eventsDelegates.sum, 3, 4);
            PassMeWork(subtract, 3, 4);
        }

        /*
         * Delegates are similar to C++ function pointers, but
         * delegates are fully object-oriented, and unlike C++ pointers to member functions, delegates encapsulate both an object instance and a method.
         * 
         * Its a function pointer
         * A delegate is a type that represents references to methods with a particular parameter list and return type. 
         * When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type. You can invoke (or call) the method through the delegate instance.
         */
        public delegate void Del(int a, int b);

        public static void PassMeWork(Del work, int a, int b)
        {
            work(a, b);
        }

        public void sum(int a, int b)
        {
            Console.WriteLine($"({a} + {b}) = {a + b}");
        }

        // method "subtract"
        public static void subtract(int a, int b)
        {
            Console.WriteLine($"({a} - {b}) = {a - b}");
        }
    }
}
