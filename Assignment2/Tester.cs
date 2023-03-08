using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Tester : Employee
    {
        // One of the child classes for the class Employee with its constructor
        // a private variable for the salary of an instance of the Tester class
        private int iSalary = 2500;
        // a static int variable that counts the amount of instances of the class Tester, updates in the constructor
        internal static int iCountTesters = 0;
        
        internal Tester(string CompanyName, string EmployeeNumber, string Name, string Address) : base(CompanyName, EmployeeNumber, Name, Address)
        {
            Tester.iCountTesters++;
        }

        // method to print the details of an instance of the class Tester
        internal void InfoPrinter()
        {
            Console.WriteLine("Tester, name: {0}, address: {1}, company: {2}, employee number: {3}, salary: {4}", this.sName, this.sAdress, this.sCompanyName, this.sEmployeeNumber, this.Salary);
        }

        // a get method to access the private variable of salary
        internal int Salary
        {
            get { return iSalary; }
        }
    }
}
