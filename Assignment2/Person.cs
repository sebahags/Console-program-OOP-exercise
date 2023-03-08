using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Person
    {
        // parent class Person and its constructor
        protected string sName;
        protected string sAdress;

        internal Person(string Name, string Address)
        {
            this.sName = Name;
            this.sAdress = Address;
        }
    }
}
