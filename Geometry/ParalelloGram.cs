using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class ParalelloGram: Square
    {
        private double tiltedDegrees;
        public ParalelloGram(string nameForGeo, double aSide, double bSide, double tiltedDegree)
        {
            Name = nameForGeo;
            A = aSide;
            B = bSide;
            C = aSide;
            D = bSide;
            tiltedDegrees = tiltedDegree;
        }

        public double AreaForParalleloGram()
        {
            return A * B * Math.Sin(tiltedDegrees);
        }
    }
}
