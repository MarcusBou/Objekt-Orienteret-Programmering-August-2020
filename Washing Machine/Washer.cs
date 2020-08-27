using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Washing_Machine
{
    class Washer
    {
        #region Attributes
        /// <summary>
        /// all the default attributes and connection, for the washer such ass, the Array where the Programs are sorted in, and the electronic values, if it is turned on,
        /// or if it is running, or hatch is closed.
        /// it is also storing error messages
        /// </summary>
        WashPrograms programs = new WashPrograms();

        private bool onOff;
        private bool running;
        private bool hatchClosed;
        private string[] washProgram;
        private string[] errors = { "Washer is not turned on", "Washer is already running", "Washer's hatch is open", "No Washer Program is selected" };


        public bool OnOff { get { return this.onOff; } set { this.onOff = value; } }
        public bool Running { get { return this.running; } set { this.running = value; } }
        public bool HatchClosed { get { return this.hatchClosed; } set { this.hatchClosed = value; } }
        public string[] WashProgram { get { return this.washProgram; } set { this.washProgram = value; } }
        public string[] Errors { get { return this.errors; } }
        #endregion

        public Washer(bool isON, bool isRunning, bool isClosed)
        {
            this.onOff = isON;
            this.running = isRunning;
            this.hatchClosed = isClosed;
        }

        public void TurnOnOrOff()
        {
            //checks if on or off then turn it oppposite, like if its off it turns on
            if (OnOff == false)
            {
                onOff = true;
            }
            else if(onOff == true)
            {
                onOff = false;
            }
        }

        public void StartWash()
        {
            //go through a checklist, too see if everything is prepared to run, if all the criteria isnt fulfilled, it post an error message
            if (onOff == true)
            {
                if (hatchClosed == true)
                {
                    if (running != true)
                    {
                        running = true;
                    }
                    else
                    {
                        Console.WriteLine(Errors[1]);
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine(Errors[2]);
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine(Errors[0]);
                Console.ReadKey();
            }
        }

        public void SelectProgram(int choice)
        {
            //Selects program from Array
                washProgram = programs.Programs[choice].Split(',');
        }

        public void TurnedOffValuesSet()
        {
            //remove all values from console.writeline about selected program when turned off, and put back a default value, when turned off
            if (onOff == false)
            {
                for (int i = 0; i < washProgram.Length; i++)
                {
                    washProgram[i] = "";
                }
            }
            else
            {
                if (WashProgram[0] == "")
                {
                    SelectProgram(0);
                }
            }

        }

        public void OpenOrCloseHatch()
        {
            //close or opens hatch
            if (hatchClosed == true)
            {
                hatchClosed = false;
            }
            else if (hatchClosed == false)
            {
                hatchClosed = true;
            }
        }

        public void washEnded()
        {
            //post when it is done and make a beep sound
            Console.WriteLine("Wash is done");
            Console.Beep();
            Console.ReadKey();
        }
    }
}
