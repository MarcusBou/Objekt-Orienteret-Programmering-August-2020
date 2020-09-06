using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class Triangle:Square
    {
        public Triangle(string nameForGeo, double aSide, double bSide, double cSide)
        {
            Name = nameForGeo;
            A = aSide;
            B = bSide;
            C = cSide;
        }

        public double AreaForTriangle()
        {
            return A * B / 2;
        }

        public double CircumferenceForTriangle()
        {
            return A + B + C;
        }
    }
}
