using System;

namespace Landkaart
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point { X = 10, Y = 20 };
            Point p2 = new Point{X = 100, Y = 200};

            Point p3 = p1 + p2;

            p1.Display();
            p2.Display();
            p3.Display();

            // 1 + 2

        }
    }
}
