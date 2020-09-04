using System;

namespace GumballMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispenser disp = new Dispenser(55);//creates dispenser with max amount
            do
            {
                Console.Clear();
                Console.WriteLine("[--------- Gumball Machine ---------]");
                Console.WriteLine("Get some gum: press any key\n");
                Console.ReadKey();
                Console.WriteLine(disp.DispenseGumball(55));//max amount of being filled up
                Console.ReadKey();

            } while (true);
            
        }
    }
}
