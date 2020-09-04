using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;

namespace GumballMachine
{
    class Dispenser
    {
        private Queue<Gum> gumLeft = new Queue<Gum>();

        public Queue<Gum> GumLeft { get { return gumLeft; } }


        public Dispenser(int limit)//Constructor, takes a limit of gum parameter.
        {
            while (gumLeft.Count < limit)//make sure the dispenser is filled to the limit
            {
                FillDispenser(limit);//fills up the dispenser with gum under creation
            }
        }

        public void FillDispenser(int limit)//takes parameter for limiter
        {
            Random rnd = new Random();
            int gumToQueue = rnd.Next(1, 7);//randomizes gum fill in
            switch (gumToQueue)
            {
                case 1:
                    if (GumPercentageFinder("Blue") <= PercentageFinder(25, limit))//Checks amount of Blue gum, and see how many there is supposed to be by Percentage finder
                    {
                        gumLeft.Enqueue(new Gum { Color = "Blue", Taste = "Blueberry" });//Enqueu a Bluebeery gum
                    }
                    break;
                case 2:
                    if (GumPercentageFinder("Purple") <= PercentageFinder(12, limit))//Checks amount of Purple gum, and see how many there is supposed to be by Percentage finder
                    {
                        gumLeft.Enqueue(new Gum { Color = "Purple", Taste = "Blackberry" });//Enqueue a Blackberry Gum
                    }
                    break;
                case 3:
                    if (GumPercentageFinder("Yellow") <= PercentageFinder(20, limit))//Checks amount of Yellow gum, and see how many there is supposed to be by Percentage finder
                    {
                        gumLeft.Enqueue(new Gum { Color = "Yellow", Taste = "Tutti Frutti" });//Enqueue a tutti frutti gum
                    }
                    break;
                case 4:
                    if (GumPercentageFinder("Orange") <= PercentageFinder(19, limit))//Checks amount of Orange gum, and see how many there is supposed to be by Percentage finder
                    {
                        gumLeft.Enqueue(new Gum { Color = "Orange", Taste = "Orange" });//Enqueue a Orange Gum
                    }
                    break;
                case 5:
                    if (GumPercentageFinder("Red") <= PercentageFinder(14, limit))//Checks amount of Red gum, and see how many there is supposed to be by Percentage finder
                    {
                        gumLeft.Enqueue(new Gum { Color = "Red", Taste = "Strawberry" });// Enqueue a Strawberry Gum
                    }
                    break;
                case 6:
                    if (GumPercentageFinder("Green") <= PercentageFinder(10, limit))//Checks amount of Green gum, and see how many there is supposed to be by Percentage finder
                    {
                        gumLeft.Enqueue(new Gum { Color = "Green", Taste = "Apple" });//Enqueue a Apple Gum
                    }
                    break;
                default:
                    break;
            }
        }

        public double PercentageFinder(float percentage, int amount)//takes parameter of how much percentage is supposed to be there, and the amount of gum there is supposed to be in the Dispenser
        {
            double returnAmount = percentage / 100;//Startout by dividing Your percentage amout divided by 100
            returnAmount = returnAmount * amount;//Times the amount
            return Math.Floor(returnAmount);//and return the rounded value
        }
        
        public double GumPercentageFinder(string color)//takes color parameter
        {
            int amount = 0;
            foreach (Gum gum in gumLeft)//go through the gumQueue
            {
                if (gum.Color.Equals(color))//see if the gum equals the color
                {
                    amount++;//count up amount how color
                }
            }
            return amount;//Return all counted up
        }

        public string DispenseGumball(int limit)//takes int limiter
        {
            if (gumLeft.Count > 0)//if there is more than 0 take one out
            {
                string gum = gumLeft.Peek().ToString();
                gumLeft.Dequeue();
                return gum;//return the gum
            }
            else
            {
                while (gumLeft.Count < limit)
                {
                    FillDispenser(limit);//fills up the dispenser
                }
                return "Your dispenser has been filled again";//tell that dispenser has been filled
            }
        }
    }
}
