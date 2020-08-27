using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Washing_Machine
{
    class GUI
    {
        //attributes
        private string turnedOn, hatchSecured; //for translation from bool too Strings
        private int selectInGui; //for your selection on washing

        public string TurnedOn { get { return this.turnedOn; } set { this.turnedOn = value; } }
        public string HatchSecured { get { return this.hatchSecured; } set { this.hatchSecured = value; } }

        Washer washer = new Washer(false, false, true);

        public void Translate()
        {
            //make sure it isnt true or false, in the console.writelines
            if (washer.OnOff == true)
            {
                turnedOn = "off";
            }
            else if(washer.OnOff == false)
            {
                turnedOn = "on";
            }

            if (washer.HatchClosed == true)
            {
                hatchSecured = "Open";
            }
            else
            {
                hatchSecured = "Close";
            }
        }

        public void guiForWasher()
        {
            //a default value on startup
            washer.SelectProgram(0);
            while (true)
            {
                Console.Clear();
                washer.TurnedOffValuesSet();
                Translate();
                Console.WriteLine("1. Turn " + turnedOn + "                        |       Program: " + washer.WashProgram[0]);
                Console.WriteLine("2. Start Program                  |");
                Console.WriteLine("3. Basic Wash                     |       Estimated time: " + washer.WashProgram[1] + " Seconds");
                Console.WriteLine("4. Eco Wash                       |       Estimated Water intake:" + washer.WashProgram[2]);
                Console.WriteLine("5. Quick Wash                     |       Estimated Water Temperature: " + washer.WashProgram[3] + "°");
                Console.WriteLine("6. Heavy Wash                     |");
                Console.WriteLine("7. " + hatchSecured + " hatch");
                Console.Write("Choice: ");
                Int32.TryParse(Console.ReadLine(), out selectInGui);

                //switch for turn on and turn off, start program, Washing program, and opening hatch
                switch (selectInGui)
                {
                    case 1:
                        washer.TurnOnOrOff();
                        break;
                    case 2:
                        washer.StartWash();
                        GuiForWhenWashing();
                        break;
                    case 3:
                        washer.SelectProgram(0);
                        break;
                    case 4:
                        washer.SelectProgram(1 );
                        break;
                    case 5:
                        washer.SelectProgram(2);
                        break;
                    case 6:
                        washer.SelectProgram(3);
                        break;
                    case 7:
                        washer.OpenOrCloseHatch();
                        break;
                    default:
                        Console.WriteLine("Out of range");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void GuiForWhenWashing()
        {
            //For when the washer is washing and counting down, and so no action can be taking while it is washing
            if (washer.Running == true)
            {
                for (int i = Int32.Parse(washer.WashProgram[1]); i > 0; --i)
                {
                    Console.Clear();
                    Translate();
                    Console.WriteLine("1. Turn " + turnedOn + "                        |       Program: " + washer.WashProgram[0]);
                    Console.WriteLine("2. Start Program                  |       Program Startede");
                    Console.WriteLine("3. Basic Wash                     |       Estimated time left: " + i + " Seconds");
                    Console.WriteLine("4. Eco Wash                       |       Estimated Water intake: " + washer.WashProgram[2]);
                    Console.WriteLine("5. Quick Wash                     |       Estimated Water Temperature: " + washer.WashProgram[3]);
                    Console.WriteLine("6. Heavy Wash                     |");
                    Console.WriteLine("7. " + hatchSecured + " hatch                     |");
                    Thread.Sleep(1000);
                }
                washer.washEnded();
            }
        }
    }
}
