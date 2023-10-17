using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.mis.htmlagilty
{
    public class HtmlAgilityPackExample
    {
        public static void Main()
        {
            // Load the HTML document
            var doc = new HtmlDocument();
            doc.Load(GetHtml());

            // Find the ul element with an id of "content"
            var contentUl = doc.DocumentNode.SelectSingleNode("//ul[@id='content']");

            // Find the first li element under the content ul
            var firstLi = contentUl.SelectSingleNode("li");

            // Extract the text of the first li element
            var firstLiText = firstLi.InnerText;

            Console.WriteLine(firstLiText); // Outputs "Item 1"

        }

        public static string GetHtml()
        {
            return "C:\\workspace\\dotnet\\ConsoleCsharp\\ManishConsoleApp\\mis\\htmlagilty\\HTMLPage.html";
                
        }


    }
}
