using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    class Rectangle
    {
        public int Width { get; }
        public int Height { get; }
        public int X { get; private set; }
        public int Y { get; private set; }


        public Rectangle(int width, int height, int x, int y)
        {
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }

        public int Area()
        {
            return Width * Height;
        }

        public bool IsContain(Point point)
        {
            if (point.X >= X && (point.X <= (X + Width)))
            {
                if (point.Y >= Y && (point.Y <= (Y + Height)))
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
        
        public bool IsIntersect(Rectangle rectangle)
        {
            Point[] points =
            {
                new Point(rectangle.X,rectangle.Y),
                new Point(rectangle.X + rectangle.Width, rectangle.Y),
                new Point(rectangle.X, rectangle.Y + rectangle.Height),
                new Point(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height)
            };

            foreach (var point in points)
            {
                if (this.IsContain(point))
                {
                    return true;
                }
            }
            return false;
        }
        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public void Scale(int scale)
        {

        }
    }
}
