using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Triang
    {
        public int Base { get; set; }
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int height { get; set; }

        public int perimeter()
        {
            return Base + side1 + side2;
        }
        public int area()
        {
            return (Base * height) / 2;
        }
    }
}
