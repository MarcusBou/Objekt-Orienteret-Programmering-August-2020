using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class Square
    {
        private string name;
        private double a, b, c, d;

        public string Name { get { return name; } set { name = value; } }
        public double A { get { return a; } set { a = value; }  }
        public double B { get { return b; } set { b = value; }  }
        public double C { get { return c; } set { c = value; }  }
        public double D { get { return d; } set { d = value; }  }

        public Square() { }

        public Square(string nameForFigure, double aSide)//A constructor, that is needed a value, before creation
        {
            name = nameForFigure;
            a = aSide;
            b = aSide;
            c = aSide;
            d = aSide;
        }

        public double Circumference()//returns the Circumference value
        {
            return a + b + c + d;
        }

        public double AreaForSquare()//returns the Area value
        {
            return Math.Pow(a, 2);
        }

    }
}
