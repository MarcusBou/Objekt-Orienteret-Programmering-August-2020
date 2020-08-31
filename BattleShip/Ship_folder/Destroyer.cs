using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BattleShip
{
    class Destroyer: Ships
    {
        private bool section1, section2, section3 = true;

        public bool Section1 { get { return section1; } set { section1 = value; } }
        public bool Section2 { get { return section2; } set { section2 = value; } }
        public bool Section3 { get { return section3; } set { section3 = value; } }

        public Destroyer(string name, int length, bool state)
        {
            shipName = name;
            shipLength = length;
            shipState = state;
        }
    }
}
