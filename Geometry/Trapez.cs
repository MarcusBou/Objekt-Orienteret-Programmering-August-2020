using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class Trapez: Square
    {
        public Trapez(string nameForGeo, double aSide, double bSide, double cSide, double dSide )
        {
            Name = nameForGeo;
            A = aSide;
            B = aSide;
            C = aSide;
            D = aSide;
        }

        public double AreaForTrapez()
        {
            double s = (A + B - C + D);
            s = s / 2;
            double h = (Math.Sqrt(s * (s - A + C) * (s - B) * (s - D)));
            h = h * (A - C) / 2;
            return (A + C) * h / 2;
        }
    }
}
