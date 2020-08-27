using PhoneWaitingLine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Queue
{
    class GUI
    {
        private bool startConsol;
        Queue phoneWaitingList = new Queue();

        public GUI(bool start)
        {
            startConsol = start;
        }

        /// <summary>
        /// The MainGUI, is used like a menu.
        /// With a switchCase, too control, witch gui it should call/use.
        /// </summary>
        public void MainGUI()
        {
            while (startConsol == true)
            {
                Console.Clear();
                Console.WriteLine("[=============================================]\n");
                Console.WriteLine("               H1 Phoneline Queue               ");
                Console.WriteLine("\n[=============================================]\n");
                Console.WriteLine(@"/==============================================\");
                Console.WriteLine("|1: Add User                                   |");
                Console.WriteLine("|2: Remove the first in line                   |");
                Console.WriteLine("|3: Show the number of users waiting           |");
                Console.WriteLine("|4: Find an waiting users number               |");
                Console.WriteLine("|5: Print all waithin users                    |");
                Console.WriteLine("|6: Exit                                       |");
                Console.WriteLine(@"\==============================================/");
                Console.Write("\nEnter Your Choice: ");
                Int32.TryParse(Console.ReadLine(), out int choice);

                switch (choice)
                {
                    case 1:
                        AddItemGui();
                        break;
                    case 2:
                        RemoveFirstInQueueGui();
                        break;
                    case 3:
                        ShowNumberOfUsersWaitingGui();
                        break;
                    case 4:
                        FindAUserWaitingGui();
                        break;
                    case 5:
                        PrintAllWaitingUsersGui();
                        break;
                    case 6:
                        startConsol = false;
                        break;
                    default:
                        Console.WriteLine("Error: out of range");
                        break;
                }
            }
        }

        /// <summary>
        /// Add Item to gui, is used to Add an item
        /// By creating a temp string and int
        /// taking the values the user, inputs and creates an object with it
        /// </summary>
        public void AddItemGui()
        {
            Console.Clear();
            Console.WriteLine("[============ Add users to the line ============]");
            Console.Write("|Your Name: ");
            string name = Console.ReadLine();
            Console.Write("|Your Number: ");
            Int32.TryParse(Console.ReadLine(), out int phoneNum);
            phoneWaitingList.AddTooQueue(new PhoneNumber { PhoneNumb = phoneNum, NameOfPhoneUser = name });
        }
        
        public void RemoveFirstInQueueGui()//Deques the first value
        {
            Console.Clear();
            Console.WriteLine(phoneWaitingList.DequeueFromPhoneWaitingList());
            Console.ReadKey();
        }

        public void ShowNumberOfUsersWaitingGui()//uses a count function to show how many is in queue
        {
            Console.Clear();
            Console.WriteLine("Number of users waiting {0}",phoneWaitingList.ReturnNumberOfUsersWaiting());
            Console.ReadKey();
        }

        public void FindAUserWaitingGui()
        {
            Console.Clear();
            Console.Write("Search for name or number?(name/number): ");//ask for what you will search for and put it into and if, so you can specify your search
            string findUserChoice = Console.ReadLine();
            if (findUserChoice.Equals("name"))
            {
                Console.Write("Search for name: ");
                string nameSearch = Console.ReadLine();
                Console.WriteLine(phoneWaitingList.FindPhoneNumber(nameSearch, 0));//searches for the name in the waiting list
                Console.ReadKey();
            }
            else if (findUserChoice.Equals("number"))
            {
                Console.Write("search for Number: ");
                Int32.TryParse(Console.ReadLine(), out int numberSearch);
                Console.WriteLine(phoneWaitingList.FindPhoneNumber("", numberSearch));//searches for the number in the waiting list
                Console.ReadKey();
            }
        }

        public void PrintAllWaitingUsersGui()//prints all the values int queue
        {
            Console.Clear();
            Console.WriteLine("[============ Users in line ============]");
            foreach (PhoneNumber WaitingUser in phoneWaitingList.PhoneLine)
            {
                Console.WriteLine("|" + WaitingUser + "|");
            }
            Console.ReadKey();
        }
    }
}
