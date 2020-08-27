using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons lars = new Persons("lars", true);
            lars.Gender = false;
            lars.Name = "Lis";
        }
    }
}
