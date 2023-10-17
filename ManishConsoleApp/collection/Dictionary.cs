using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.collection
{
    public class Dictionary
    {

        
        static void Main(string[] args)
        {
            // create a new HashMap
            Dictionary<string, int> hashMap = new Dictionary<string, int>
            {
                // add key-value pairs to the HashMap
                { "apple", 2 },
                { "banana", 3 },
                { "orange", 4 }
            };
            hashMap.Add("mango", 5);
            // retrieve a value from the HashMap using a key
            int appleCount = hashMap["apple"];
            Console.WriteLine("There are {0} apples.", appleCount);

            // modify a value in the HashMap using a key
            hashMap["banana"] = 5;
            Console.WriteLine("There are now {0} bananas.", hashMap["banana"]);

            // iterate over the key-value pairs in the HashMap
            foreach (KeyValuePair<string, int> entry in hashMap)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}" );
            }
            foreach (var key in hashMap.Keys)
            {
                Console.WriteLine($"{key}: {hashMap[key]}");
            }
        }
    }
}
