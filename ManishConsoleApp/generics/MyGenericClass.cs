using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.generics
{
    public class MyGenericClass<T>
    {

        public static void Main(){
            MyGenericClass<int> intObj = new MyGenericClass<int>(10);
            int myInt = intObj.GetData(); // myInt is equal to 10

            MyGenericClass<string> stringObj = new MyGenericClass<string>("Hello, world!");
            string myString = stringObj.GetData(); // myString is equal to "Hello, world!"

        }

        private T data;

        public MyGenericClass(T data)
        {
            this.data = data;
        }

        public T GetData()
        {
            return this.data;
        }
    }
}
