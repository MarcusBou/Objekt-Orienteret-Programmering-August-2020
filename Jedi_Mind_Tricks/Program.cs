using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi_Mind_Tricks
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>();
            people.Add("Marcus", 18);//add people too list through .add method
            people["Sebastian"] = 20;//add people too list through Key

            Dictionary<string, bool> characters = new Dictionary<string, bool>()
             {
                 { "Luke", true },
                 { "Han", false },
                 { "Chewbacca", false }
            };//adds three new name to dictionary
            characters.Remove("Han");// removes han from dictionary

            Console.WriteLine("Firstperson, in people");
            Console.WriteLine(people.First());//show the first person in the dicionary people
            Console.ReadKey();

            Console.WriteLine("\nPrinted out people, and character directory: ");
            foreach (var peoples in people)
            {
                Console.WriteLine(peoples);//print out the peoples dictionary
            }

            foreach (var character in characters)
            {
                Console.WriteLine(character);//Print out the Characters Dictionary
            }

            Console.ReadKey();
        }
    }
}
