using System;
using System.Collections.Generic;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square("Square", 8);
            Rectangle rectangle = new Rectangle("Rectangle",15, 9);
            ParalelloGram paralelloGram = new ParalelloGram("paralelloGram",10, 5, 25);
            Trapez trapez = new Trapez("Trapez", 10, 9, 8, 9);
            Triangle triangle = new Triangle("Triangle",10, 8, 12);

            List<Square> listOfGeometry = new List<Square>();
            listOfGeometry.Add(square);
            listOfGeometry.Add(rectangle);
            listOfGeometry.Add(paralelloGram);
            listOfGeometry.Add(trapez);
            listOfGeometry.Add(triangle);

            foreach (Square Geo in listOfGeometry)
            {
                Console.WriteLine("Name: {0}, Area: {1}, Circumference: {2}", Geo.Name, findRightAreaMethod(Geo.Name, square, rectangle, paralelloGram, trapez, triangle), findRightCircumference(Geo.Name, square, triangle));
            }
            Console.ReadKey();
        }

        static double findRightAreaMethod(string NameOfGeo, Square square, Rectangle rectangle, ParalelloGram paralelloGram, Trapez trapez, Triangle triangle)
        {
            if (NameOfGeo.Equals("Square"))
            {
                return square.AreaForSquare();
            }
            else if (NameOfGeo.Equals("Rectangle"))
            {
                return rectangle.AreaForRectangle();
            }
            else if (NameOfGeo.Equals("paralelloGram"))
            {
                return paralelloGram.AreaForParalleloGram();
            }
            else if (NameOfGeo.Equals("Trapez"))
            {
                return trapez.AreaForTrapez();
            }
            else if (NameOfGeo.Equals("Triangle"))
            {
                return triangle.AreaForTriangle();
            }
            else
            {
                return 0;
            }
        }
        static double findRightCircumference(string geo, Square square, Triangle triangle)
        {
            if (geo.Equals("Triangle"))
            {
                return triangle.CircumferenceForTriangle();
            }
            else
            {
                return square.Circumference();
            }
        }
    }
}
