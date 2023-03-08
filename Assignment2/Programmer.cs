using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Programmer : Employee
    {
        // One of the child classes for the class Employee with its constructor
        // a private variable for the salary of an instance of the Programmer class
        private int iSalary = 3500;
        // a static int variable that counts the amount of instances of the class Programmer, updates in the constructor
        internal static int iCountProgrammers = 0;
        internal Programmer(string CompanyName, string EmployeeNumber, string Name, string Address ) : base(CompanyName, EmployeeNumber, Name, Address)
        {
            Programmer.iCountProgrammers++;
        }

        // method to print the details of an instance of the class Programmer
        internal void InfoPrinter()
        {
            Console.WriteLine("Programmer, name: {0}, address: {1}, company: {2}, employee number: {3}, salary: {4}", this.sName, this.sAdress, this.sCompanyName, this.sEmployeeNumber, this.Salary);
        }

        // a get method to access the private variable of salary
        internal int Salary
        {
            get { return iSalary; }
        }
    }
}
