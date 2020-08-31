using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace BattleShip
{
    class Ships
    {
        private string shipName;
        private bool shipState;
        private int shipLength;

        public string ShipName { get { return shipName; } set { shipName = value; } }

        public Ships() { }
    }
}
