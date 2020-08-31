using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip.Ship_folder
{
    class Slagskib: Ships
    {
        private bool section1, section2, section3, section4, section5 = true;

        public bool Section1 { get { return section1; } set { section1 = value; } }
        public bool Section2 { get { return section2; } set { section2 = value; } }
        public bool Section3 { get { return section3; } set { section3 = value; } }
        public bool Section4 { get { return section4; } set { section4 = value; } }
        public bool Section5 { get { return section5; } set { section5 = value; } }

        public Slagskib(string name, int length, bool state)
        {
            shipName = name;
            shipLength = length;
            shipState = state;
        }
    }
}
