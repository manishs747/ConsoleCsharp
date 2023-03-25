using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.files
{
    public class CreateFile
    {

        public static void Main()
        {
            const string filename = "C:\\workspace\\dotnet\\ConsoleCsharp\\ManishConsoleApp\\files\\Document.txt";

            // Create a new file - this will overwrite any existing file
            // Use the "using" construct to automatically close the file stream
            using (StreamWriter sw = File.CreateText(filename))
            {
                sw.WriteLine("This is a Manish file.");
            }

            // Determine if a file exists
            Console.WriteLine(File.Exists(filename));
         /*   if (File.Exists(filename))
            {
                // The Delete function deletes a file
                File.Delete(filename);
            }
            else
            {
                using (StreamWriter sw = File.CreateText(filename))
                {
                    sw.WriteLine("This is a text file.");
                }
            }
            Console.WriteLine(File.Exists(filename));*/

        }
    }
}
