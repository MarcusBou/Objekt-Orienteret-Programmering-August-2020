using System;

namespace GumballMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispenser disp = new Dispenser(55);
            Console.WriteLine(disp.GumLeft.Count);
            foreach (Gum item in disp.GumLeft)
            {
                Console.WriteLine(item);
            }
        }
    }
}
