using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneWaitingLine
{
    class PhoneNumber
    {
        private string nameOfPhoneUser;
        private int phoneNumb;
        public string NameOfPhoneUser { get { return nameOfPhoneUser; } set { nameOfPhoneUser = value; } }
        public int PhoneNumb { get { return phoneNumb; } set { phoneNumb = value; } }

        public PhoneNumber() { }

        public PhoneNumber(int phoneNmb, string NameOfPhoneUser)
        {
            nameOfPhoneUser = NameOfPhoneUser;
            phoneNumb = phoneNmb;
        }

        public override string ToString()
        {
            return "Name of User: " + nameOfPhoneUser + "Number: " + phoneNumb;
        }
    }
}
