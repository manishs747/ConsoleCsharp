using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.collection
{
    public class Lists
    {

        public static void Main() {
            var list = new List<string>();
            string[] animals = { "Cow", "Camel", "Elephant" };
            List<string> animalsList = new List<string>(animals);
            foreach (string a in animalsList)
                Console.WriteLine(a);


        }
    }
}
