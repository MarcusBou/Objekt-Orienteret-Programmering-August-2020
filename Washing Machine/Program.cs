using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Washing_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            GUI gui = new GUI();
            gui.guiForWasher();
            Console.ReadLine();
        }
    }
}
