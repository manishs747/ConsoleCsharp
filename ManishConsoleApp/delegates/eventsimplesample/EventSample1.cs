using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.event_delegates.eventsimplesample
{
    public class EventSample1
    {
        public delegate void MyDelgate(string message);
        public  static event MyDelgate MyEvent;

        public static event EventHandler<EventArgs> EventHandlerInBuld;

        public static void Main()
        {
            MyEvent += HandleEvent;
            MyEvent += (x) => Console.WriteLine($"Inside Lambda Delegate {x}");
            MyEvent +=  new MyDelgate(HandleEvent);

            EventHandlerInBuld += EventSample1_EventHandlerInBuld;
        }

        private static void EventSample1_EventHandlerInBuld(object? sender, EventArgs e)
        {
            Console.WriteLine($"Inside EventSample1_EventHandlerInBuld Delegate {sender}");
        }

        public static void HandleEvent(string message)
        {
            Console.WriteLine("Message received: {0}", message);
        }

        public static void RaiseEvent(string message)
        {
          /*  if (MyEvent != null)
            {
                MyEvent(message);
            }*/
            MyEvent?.Invoke(message);
            EventHandlerInBuld?.Invoke(message, null);
        }

    }
}
