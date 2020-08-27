using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Persons
    {
        private string name;
        private bool gender;

        public string Name
        {
            get { return name; }
            set
            {
                if (value != "Lis")
                {
                    name = value;
                }
            } }
        public bool Gender { get { return gender; } set { gender = value; } }

        public Persons()
        {

        }

        public Persons(string name, bool gender)
        {
            Name = name;
            Gender = gender;
        }
    }
}
