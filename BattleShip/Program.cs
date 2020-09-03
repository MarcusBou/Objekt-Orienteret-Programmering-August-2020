using System;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battlefield = new Battlefield();
            while (true)
            {
                Console.Clear();
                Console.WriteLine(battlefield);
                ConsoleKey consoleKey = Console.ReadKey().Key;
                battlefield.controlShipPlacement(consoleKey);
            }
        }
    }
}
