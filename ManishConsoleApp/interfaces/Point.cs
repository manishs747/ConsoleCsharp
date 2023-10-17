using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.interfaces
{
    public class Point : IPoint
    {

        static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0}, y={1}", p.X, p.Y);
        }

        static void Main()
        {
            IPoint p = new Point(2, 3);
            Console.Write("My Point: ");
            PrintPoint(p);
        }

        public Point() { }
       

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Property implementation:
        public int X { get; set; }
        public int Y { get; set; }

  

        // Property implementation
        public double Distance =>
           Math.Sqrt(X * X + Y * Y);
    }
}
