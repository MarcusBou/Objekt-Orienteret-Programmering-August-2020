using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class Rectangle:Square
    {
        public Rectangle(string nameForGeo, double aSide, double bSide)
        {
            Name = nameForGeo;
            A = aSide;
            B = bSide;
            C = aSide;
            D = bSide;
        }

        public double AreaForRectangle()
        {
            return A * B;
        }
    }
}
