using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BattleShip
{
    class Battlefield
    {
        private int x = 0;
        private int y = 0;
        private bool horizontailVertical = true;
        private List<Coordinates> tempCoor = new List<Coordinates>();

        Ships patrolBoat = new Ships("Patrol Boat", 3, true, "p");

        string[,] battlefield = new string[10, 10];
        bool[,] shipPlacement = new bool[10, 10];

        public Battlefield()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    battlefield[i, j] = " ";
                    shipPlacement[i, j] = false;
                }
            }
        }

        public void controlShipPlacement(ConsoleKey consoleKey)
        {
            tempCoor.Clear();
            for (int i = 0; i < patrolBoat.ShipLength; i++)
            {
                if (x >= 0 && y >= 0 && x + patrolBoat.ShipLength < 10 && y + patrolBoat.ShipLength < 10)
                {
                    if (horizontailVertical == true) {tempCoor.Add(new Coordinates { X = x + i, Y = y });}
                    else if (horizontailVertical == false) {tempCoor.Add(new Coordinates { X = x, Y = y + i });}
                }
                else
                {
                    if (x < 0) { x = 0; }
                    else if (y < 0) { y = 0; }
                    else if (x > 10) { y = 9; }
                    else if (y > 10) { y = 9; }
                }
            }
            switch (consoleKey)
            {
                case ConsoleKey.LeftArrow:
                    x = x - 1;
                    break;
                case ConsoleKey.UpArrow:
                    y = y - 1;
                    break;
                case ConsoleKey.RightArrow:
                    x = x + 1;
                    break;
                case ConsoleKey.DownArrow:
                    y = y + 1;
                    break;
                case ConsoleKey.R:
                    if (horizontailVertical == true)
                    {
                        horizontailVertical = false;
                    }
                    else if (horizontailVertical == false)
                    {
                        horizontailVertical = true;
                    }
                    break;
                default:
                    break;
            }
            RotatedHorizontal();
        }

        public void RotatedHorizontal()
        {
            if (horizontailVertical == true)
            {
                if (x + patrolBoat.ShipLength < 10 && x >= 0 && y < 10 && y >= 0)
                {
                    foreach (Coordinates Co in tempCoor)
                    {
                        battlefield[Co.Y, Co.X] = " ";
                    }
                    for (int i = 0; i < patrolBoat.ShipLength; i++)
                    {
                        battlefield[y, x + i] = patrolBoat.ShipIndicator;
                    }
                }
                
            }
            else if (horizontailVertical == false)
            {
                if (x < 10 && x >= 0 && y + patrolBoat.ShipLength < 10 && y >= 0)
                {
                    foreach (Coordinates Co in tempCoor)
                    {
                        battlefield[Co.Y, Co.X] = " ";
                    }
                    for (int i = 0; i < patrolBoat.ShipLength; i++)
                    {
                        battlefield[y + i, x] = patrolBoat.ShipIndicator;
                    }
                }
                
            }
        }
        
        public override string ToString()
        {
            return "----------------------------------------\n" +
                   "| " + battlefield[0, 0] + " | " + battlefield[0, 1] + " | " + battlefield[0, 2] + " | " + battlefield[0, 3] + " | " + battlefield[0, 4] + " | " + battlefield[0, 5] + " | " + battlefield[0, 6] + " | " + battlefield[0, 7] + " | " + battlefield[0, 8] + " | " + battlefield[0, 9] + " |\n" +
                   "----------------------------------------\n" +
                   "| " + battlefield[1, 0] + " | " + battlefield[1, 1] + " | " + battlefield[1, 2] + " | " + battlefield[1, 3] + " | " + battlefield[1, 4] + " | " + battlefield[1, 5] + " | " + battlefield[1, 6] + " | " + battlefield[1, 7] + " | " + battlefield[1, 8] + " | " + battlefield[1, 9] + " |\n" +
                   "----------------------------------------\n" +
                   "| " + battlefield[2, 0] + " | " + battlefield[2, 1] + " | " + battlefield[2, 2] + " | " + battlefield[2, 3] + " | " + battlefield[2, 4] + " | " + battlefield[2, 5] + " | " + battlefield[2, 6] + " | " + battlefield[2, 7] + " | " + battlefield[2, 8] + " | " + battlefield[2, 9] + " |\n" +
                   "----------------------------------------\n" +
                   "| " + battlefield[3, 0] + " | " + battlefield[3, 1] + " | " + battlefield[3, 2] + " | " + battlefield[3, 3] + " | " + battlefield[3, 4] + " | " + battlefield[3, 5] + " | " + battlefield[3, 6] + " | " + battlefield[3, 7] + " | " + battlefield[3, 8] + " | " + battlefield[3, 9] + " |\n" +
                   "----------------------------------------\n" +
                   "| " + battlefield[4, 0] + " | " + battlefield[4, 1] + " | " + battlefield[4, 2] + " | " + battlefield[4, 3] + " | " + battlefield[4, 4] + " | " + battlefield[4, 5] + " | " + battlefield[4, 6] + " | " + battlefield[4, 7] + " | " + battlefield[4, 8] + " | " + battlefield[4, 9] + " |\n" +
                   "----------------------------------------\n" +
                   "| " + battlefield[5, 0] + " | " + battlefield[5, 1] + " | " + battlefield[5, 2] + " | " + battlefield[5, 3] + " | " + battlefield[5, 4] + " | " + battlefield[5, 5] + " | " + battlefield[5, 6] + " | " + battlefield[5, 7] + " | " + battlefield[5, 8] + " | " + battlefield[5, 9] + " |\n" +
                   "----------------------------------------\n" +
                   "| " + battlefield[6, 0] + " | " + battlefield[6, 1] + " | " + battlefield[6, 2] + " | " + battlefield[6, 3] + " | " + battlefield[6, 4] + " | " + battlefield[6, 5] + " | " + battlefield[6, 6] + " | " + battlefield[6, 7] + " | " + battlefield[6, 8] + " | " + battlefield[6, 9] + " |\n" +
                   "----------------------------------------\n" +
                   "| " + battlefield[7, 0] + " | " + battlefield[7, 1] + " | " + battlefield[7, 2] + " | " + battlefield[7, 3] + " | " + battlefield[7, 4] + " | " + battlefield[7, 5] + " | " + battlefield[7, 6] + " | " + battlefield[7, 7] + " | " + battlefield[7, 8] + " | " + battlefield[7, 9] + " |\n" +
                   "----------------------------------------\n" +
                   "| " + battlefield[8, 0] + " | " + battlefield[8, 1] + " | " + battlefield[8, 2] + " | " + battlefield[8, 3] + " | " + battlefield[8, 4] + " | " + battlefield[8, 5] + " | " + battlefield[8, 6] + " | " + battlefield[8, 7] + " | " + battlefield[8, 8] + " | " + battlefield[8, 9] + " |\n" +
                   "----------------------------------------\n" +
                   "| " + battlefield[9, 0] + " | " + battlefield[9, 1] + " | " + battlefield[9, 2] + " | " + battlefield[9, 3] + " | " + battlefield[9, 4] + " | " + battlefield[9, 5] + " | " + battlefield[9, 6] + " | " + battlefield[9, 7] + " | " + battlefield[9, 8] + " | " + battlefield[9, 9] + " |\n" +
                   "----------------------------------------\n";
        }
    }
}
