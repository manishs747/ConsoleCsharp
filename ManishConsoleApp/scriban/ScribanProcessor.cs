using SB = Scriban;

namespace ManishConsoleApp.scriban
{
    public class ScribanProcessor
    {
        public static void Main() {
            string file = "./scriban/invoice.html";
            if (File.Exists(file))
            {
                Console.WriteLine("The file exists.");
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
            File.WriteAllText(file, Process());
        }

        private static string Process()
        {
             var template = SB.Template.Parse(File.ReadAllText("./scriban/index.html"));
             return template.Render(new { Name = "Manish" });
        }
    }
}
