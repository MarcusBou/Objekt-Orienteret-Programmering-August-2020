using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Text;

namespace BattleShip
{
    class Coordinates
    {
        private int x;
        private int y;

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        public Coordinates() { }

        public Coordinates(int getX, int getY)
        {
            x = getX;
            y = getY;
        }
    }
}
