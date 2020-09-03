using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GumballMachine
{
    class Gum
    {
        private string color;
        private string taste;
        
        public string Color { get { return color; } set { color = value; } }
        public string Taste { get { return taste; } set { taste = value; } }

        public Gum() { }

        public override string ToString()
        {
            return taste;
        }
    }
}
