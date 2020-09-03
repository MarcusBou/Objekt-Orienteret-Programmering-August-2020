using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    class Ships
    {
        protected string shipName;
        protected int shipLength;
        protected bool shipState;
        protected string shipIndicator;
        private List<bool> shipSegments = new List<bool>();

        public string ShipName { get { return shipName; } }
        public int ShipLength { get { return shipLength; } }
        public bool ShipState { get { return shipState; } }
        public string ShipIndicator { get { return shipIndicator; } }
        public List<bool> ShipSegments { get { return ShipSegments; } }

        public Ships(string name, int length, bool state, string indicator)
        {
            shipName = name;
            shipLength = length;
            shipState = state;
            shipIndicator = indicator;
            for (int i = 0; i <= length; i++)
            {
                shipSegments.Add(true);
            }
        }

    }
}
