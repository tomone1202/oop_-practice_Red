using System;

namespace OOP
{


    abstract class Shape
    {

        protected int Area { get; set; }
        public int GetArea() => CalArea();
        protected abstract int CalArea();
    }

    class Square : Shape
    {
        private readonly int _side;

        public Square(int sildeLength) => _side = sildeLength;

        protected override int CalArea()
        {
            Area = _side * _side;
            return Area;
        }


        public void PrintArea()
        {
            Console.WriteLine($"面積是{Area}");
        }
    }
    class Circle : Shape
    {
        private readonly int _radius;

        public Circle(int radius) => _radius = radius;

        protected override int CalArea()
        {
            Area = (int)(_radius * _radius * 3.1415);
            return Area;
        }


        public void PrintArea()
        {
            Console.WriteLine($"面積是{Area}");
        }
    }
    class Triangle : Shape
    {

        private int Width { get; set; }
        private int Height { get; set; }

        public Triangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        protected override int CalArea()
        {
            Area = (int)(Width * Height * 0.5);
            return Area;
        }


        public void PrintArea()
        {
            Console.WriteLine($"面積是{Area}");
        }
    }
    internal class Program
    {

        static void Main()
        {
            var sq = new Square(12);
            Console.WriteLine($"我是GetArea={sq.GetArea()}");
            sq.PrintArea();
            var circle = new Circle(10);
            Console.WriteLine($"我是GetArea={circle.GetArea()}");
            circle.PrintArea();
            var tri = new Triangle(10,10);
            Console.WriteLine($"我是GetArea={tri.GetArea()}");
            tri.PrintArea();
        }
    }
}
