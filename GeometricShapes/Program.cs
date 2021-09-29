using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Square(4);
            s1.Print();

            var s2 = new Square(5);
            s2.Print();

            var r1 = new Rect()
            {
                side1 = 3, side2 = 5, side3 = 3, side4 = 5
            };
            r1.Print();

            var r2 = new Rect(3, 7);
            r2.Print();

            var q1 = new Quad(3, 4, 5, 6);
            q1.Print();

            var t1 = new Triang()
            {
                Base = 5, side1 = 8, side2 = 9, height = 7
            };
            Console.WriteLine($"Triangle1 perimeter is {t1.perimeter()}.");
            Console.WriteLine($"Triangle1 area is {t1.area()}.");
        }
    }
}
