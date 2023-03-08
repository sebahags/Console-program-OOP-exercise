using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Employee : Person
    {
        // fisrt childclass of the class Person and its constructor
        protected string sCompanyName;
        protected string sEmployeeNumber;

        protected Employee(string CompanyName, string EmployeeNumber, string Name, string Address) : base(Name, Address)
        {
            this.sCompanyName = CompanyName;
            this.sEmployeeNumber = EmployeeNumber;
        }
    }
}
