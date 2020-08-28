using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class Square
    {
        private double a;

        public double A { get { return a; } set { a = value; }  }

        public Square() { }

        public Square(double aSide)//A constructor, that is needed a value, before creation
        {
            a = aSide;
        }

        public double Circumference()//returns the Circumference value
        {
            return a * 4;
        }

        public double Area()//returns the Area value
        {
            return Math.Pow(a, 2);
        }

    }
}
