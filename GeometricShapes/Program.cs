using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Square()
            {
                side1 = 4
            };
            Console.WriteLine($"Perimeter is {s1.perimeter()}");
            Console.WriteLine($"Area is {s1.area()}");


            var r1 = new Rect()
            {
                side1 = 3, side2 = 5
            };
            Console.WriteLine($"Perimeter is {r1.perimeter()}");
            Console.WriteLine($"Area is {r1.area()}");


            var q1 = new Quad()
            {
                side1 = 3, side2 = 4, side3 = 5, side4 = 6
            };
            Console.WriteLine($"Perimeter is {q1.perimeter()}");
        }
    }
}
