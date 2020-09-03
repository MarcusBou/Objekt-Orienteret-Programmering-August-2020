using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GumballMachine
{
    class Dispenser
    {
        private Queue<Gum> gumLeft = new Queue<Gum>();

        public Queue<Gum> GumLeft { get { return gumLeft; } }

        public Dispenser(int limit)
        {
            while (gumLeft.Count < limit)
            {
                FillDispenser();
            }
        }

        public void FillDispenser()
        {
            Random rnd = new Random();
            int gumToQueue = rnd.Next(1, 7);
            switch (gumToQueue)
            {
                case 1:
                    gumLeft.Enqueue(new Gum { Color = "Blue", Taste = "Blueberry" });
                    break;
                case 2:
                    gumLeft.Enqueue(new Gum { Color = "Purple", Taste = "Blackberry" });
                    break;
                case 3:
                    gumLeft.Enqueue(new Gum { Color = "Yellow", Taste = "Tutti Frutti" });
                    break;
                case 4:
                    gumLeft.Enqueue(new Gum { Color = "Orange", Taste = "Orange" });
                    break;
                case 5:
                    gumLeft.Enqueue(new Gum { Color = "Red", Taste = "Strawberry" });
                    break;
                case 6:
                    gumLeft.Enqueue(new Gum { Color = "Green", Taste = "Apple" });
                    break;
                default:
                    break;
            }
        }
    }
}
