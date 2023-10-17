using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.mis.transformjson
{
    public class JsonTransform
    {
       public static void Main() {

            // Define the input JSON object
            string inputJson = "{ \"name\": \"John Smith\", \"age\": 30 }";

            // Define the transformation specification
            string transformSpec = "{ \"name\": \"newName\", \"age\": \"newAge\" }";

            // Load the transformation specification
            var transform = JsonConvert.DeserializeObject<JObject>(transformSpec);


            Console.WriteLine(transform);


            // Load the input JSON object
            var input = JsonConvert.DeserializeObject<JObject>(inputJson);

            // Transform the input JSON object using the transformation specification
            var output = new JObject();
            foreach (var property in transform)
            {
                output[property.Value.ToString()] = input[property.Key];
            }

            // Convert the output JSON object to a string
            string outputJson = JsonConvert.SerializeObject(output);
            Console.WriteLine(outputJson);
        }
    }
}
