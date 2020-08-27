using PhoneWaitingLine;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Queue 
{
    class Queue: PhoneNumber
    {
        //Creates queue, with purpose too hold the numbers, of the users
        Queue<PhoneNumber> phoneLine = new Queue<PhoneNumber>();
        public Queue<PhoneNumber> PhoneLine { get { return phoneLine; } }

        //add numbers/user to the queue
        public void AddTooQueue(PhoneNumber phoneNMB)
        {
            phoneLine.Enqueue(phoneNMB);
        }

        //Dequeu next element in the queue, with error messages if, queue is empty
        public string DequeueFromPhoneWaitingList()
        {
            if (phoneLine.Count != 0)
            {
                string tempString = phoneLine.Peek().NameOfPhoneUser;//Creates a temporary string so it can be used, too display what user's name that was removed
                int tempNumb = phoneLine.Peek().PhoneNumb;//Creates a temporary int so it can be used, too display what user's Number that was removed
                phoneLine.Dequeue();
                return string.Format("User: {0}. With Number: {1}. Has left the Queue", tempString, tempNumb);//Returns a line to a Writeline confirming it was removed
            }
            else
            {
                return "Error: Queue is empty";//returns an error, when queue is empty
            }
        }

        //shows how many Users are in line
        public int ReturnNumberOfUsersWaiting()
        {
            return phoneLine.Count;
        }

        //Search for phoneNumber or users Name
        public string FindPhoneNumber(string nameValue, int numbValue)
        {
            foreach (PhoneNumber Number in phoneLine)
            {
                if (Number.NameOfPhoneUser.Equals(nameValue) || Number.PhoneNumb == numbValue)//checks if name or number is true and exixts in the queue
                {
                    return string.Format("User {0} , is in queue", Number.NameOfPhoneUser);//Returns a string to a writeline confiming the object does exist
                }
            }
            return string.Format("User: {0}, with Number {1}, doesnt exist", nameValue, numbValue);//Returns Error message
        }
    }
}
