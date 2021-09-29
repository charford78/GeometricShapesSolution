using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Rect : Quad
    {
        public new void Print()
        {
            Console.WriteLine($"The Perimeter is {perimeter()} and the Area is {area()}.");
        }
        public int area()
        {
            return side1 * side2;
        }
        public Rect(int SideA, int SideB) : base(SideA, SideB, SideA, SideB)
        {         
        }
        public Rect () { }
    }
}
