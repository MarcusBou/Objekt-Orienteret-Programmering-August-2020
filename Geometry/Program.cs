using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates 4 Square's with a given value, and One that is suppossed to get its value later
            Square square1 = new Square(5);
            Square square2 = new Square(4.5);
            Square square3 = new Square(9.9);
            Square square4 = new Square(12);
            Square customSquare = new Square();

            //Prints out The returned values from Area and Circumference
            Console.WriteLine("Area for first square: " + square1.Area() + " | Circumferemnce for first square: " + square1.Circumference());
            Console.WriteLine("Area for second square: " + square2.Area() + " | Circumferemnce for second square: " + square2.Circumference());
            Console.WriteLine("Area for third square: " + square3.Area() + " | Circumferemnce for third square: " + square3.Circumference());
            Console.WriteLine("Area for fourth square: " + square4.Area() + " | Circumferemnce for fourth square: " + square4.Circumference());


            Console.Write("Set a Custom Value for a square: ");//input value for side length, to customSquare
            double.TryParse(Console.ReadLine(), out double a);
            customSquare.A = a;//sets the sidelength through a {Get; set;}
            Console.WriteLine("Area for first square: " + customSquare.Area() + " | Circumferemnce for first square: " + customSquare.Circumference());//prints out the customSquares Area, and circumference
            Console.ReadKey();
        }
    }
}
