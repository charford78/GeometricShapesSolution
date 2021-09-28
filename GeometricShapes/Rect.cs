using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Rect
    {
        public int side1 { get; set; }
        public int side2 { get; set; }

        public int perimeter()
        {
            return (side1 * 2) + (side2 * 2);
        }

        public int area()
        {
            return side1 * side2;
        }
    }
}
