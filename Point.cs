using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Radius()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public void MoveTo(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool IsEqual(Point point)
        {
            return (X == point.X && X == point.X) ? true : false;
        }
    }
}
