using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(6, 1);
            Point p2 = new Point(10, 4);
            Point p3 = new Point(12, 3);
            Point p4 = new Point(12, 3);

            Console.WriteLine("Point check");
            bool equal12 = p1.IsEqual(p2);
            Console.WriteLine(equal12);

            bool equal34 = p3.IsEqual(p4);
            Console.WriteLine(equal34);

            Console.WriteLine("Rectangles check");
            Rectangle rectangle1 = new Rectangle(6, 2, 3, 1);
            Rectangle rectangle2 = new Rectangle(1, 4, 4, 2);
            Rectangle rectangle3 = new Rectangle(2, 2, 7, 4);

            bool contain1 = rectangle1.IsIntersect(rectangle2);
            Console.WriteLine(contain1);

            bool contain2 = rectangle1.IsIntersect(rectangle3);
            Console.WriteLine(contain2);

            //bool contain2 = rectangle.IsContain(p2);
            //Console.WriteLine(contain2);

        }
    }
}
