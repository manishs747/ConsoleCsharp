using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManishConsoleApp.event_delegates.del
{

    public delegate void Del2(string message); // it only declare

    public class SimpleDelegate
    {

        public delegate void Del(string message); // it only declare

        public static int count = 0;

        // Call the delegate.


        public static void Main()
        {
            SimpleDelegate simpleDelegate = new SimpleDelegate();
            Del handler = simpleDelegate.DelegateMethod;
            
            handler += simpleDelegate.DelegateMethod;
            handler += simpleDelegate.DelegateMethod;
            handler("Hello Manish its Delicate");

            Del2 handler2 = simpleDelegate.DelegateMethod;
            handler2("Hello Manish its Delicate2");
            handler2.DynamicInvoke("heello");
        }



        // Create a method for a delegate.
        public void DelegateMethod(string message)
        {
            count++;
            Console.WriteLine(message+" :"+count);
        }
    }
}
