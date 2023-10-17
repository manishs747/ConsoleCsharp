using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.collection
{


    /**
     * Array list was old new is List<T>
     * 
     * **/
    public class ArrayLists
    {
        public static void Main()
        {

            ArrayList parts = new ArrayList { 1, 2, 3, 4 };
            List<int> numbers = new List<int>
            {
                1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16,
            };
            numbers.Add(6);
            numbers.AddRange(new int[] {7,8,9,10});

            // loop through the ArrayList and print each item
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
