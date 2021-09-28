using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Square
    {
        public int side1 { get; set; }

        public int perimeter()
        {
            return side1 * 4;
        }

        public int area()
        {
            return side1 * side1;
        }
    }

}
