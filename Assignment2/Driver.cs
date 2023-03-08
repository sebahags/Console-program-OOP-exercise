using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Driver
    {
        // A Driver class to make the user interface
        // Protected string variables to store the user-inputs from the console
        protected string sChoice;
        protected string sName;
        protected string sAddress;
        protected string sCompanyName;
        protected string sEmployeeNumber;
        // Protected boolean to handle the loop of the program, when this is set to flase the run of the program stops
        protected bool Running = true;
        // Lists to store the instances of the three employee types the user can create
        List<Programmer> programmers = new List<Programmer>();
        List<Marketer> marketers = new List<Marketer>();
        List<Tester> testers = new List<Tester>();  

        public void UserInterface()
        {
            while (Running) 
            {
                // Sets up the menu of the user interface in the console, user chooses option by inputting 0-6 and pressing enter, the choice is stored in 
                // variable sChoice
                Console.WriteLine("Here are your options:");
                Console.WriteLine("1) Add a programmer");
                Console.WriteLine("2) Add a marketer");
                Console.WriteLine("3) Add a tester");
                Console.WriteLine("4) Print all the employees and their details");
                Console.WriteLine("5) Calculate and print the number of emplyees in each category");
                Console.WriteLine("6) Calculate and print the total salary cost");
                Console.WriteLine("0) Exit the program");
                Console.Write("Choose your action by entering its number and by pressing enter: ");
                sChoice = Console.ReadLine();

                // if block to make the different interactions depending on what the user chooses
                if (sChoice == "1")
                {
                    // Creates an instance of the class Programmer with the parameters the user inputs
                    // Adds the object to the list of programmers
                    Console.Write("Please input the name and press enter: ");
                    sName = Console.ReadLine();
                    Console.Write("Please input the address and press enter: ");
                    sAddress = Console.ReadLine();
                    Console.Write("Please input the name of the company and press enter: ");
                    sCompanyName = Console.ReadLine();
                    Console.Write("Please input the employeenumber and press enter: ");
                    sEmployeeNumber = Console.ReadLine();
                    Console.WriteLine("Programmer added.");
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                    Programmer prog = new Programmer(sCompanyName, sEmployeeNumber, sName, sAddress);
                    programmers.Add(prog);
                }
                else if (sChoice == "2")
                {
                    // Creates an instance of the class Marketer with the parameters the user inputs
                    // Adds the object to the list of marketers
                    Console.Write("Please input the name and press enter: ");
                    sName = Console.ReadLine();
                    Console.Write("Please input the address and press enter: ");
                    sAddress = Console.ReadLine();
                    Console.Write("Please input the name of the company and press enter: ");
                    sCompanyName = Console.ReadLine();
                    Console.Write("Please input the employeenumber and press enter: ");
                    sEmployeeNumber = Console.ReadLine();
                    Console.WriteLine("Marketer added.");
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                    Marketer mark = new Marketer(sCompanyName, sEmployeeNumber, sName, sAddress);
                    marketers.Add(mark);
                }
                else if (sChoice == "3")
                {
                    // Creates an instance of the class Tester with the parameters the user inputs
                    // Adds the object to the list of testers
                    Console.Write("Please input the name and press enter: ");
                    sName = Console.ReadLine();
                    Console.Write("Please input the address and press enter: ");
                    sAddress = Console.ReadLine();
                    Console.Write("Please input the name of the company and press enter: ");
                    sCompanyName = Console.ReadLine();
                    Console.Write("Please input the employeenumber and press enter: ");
                    sEmployeeNumber = Console.ReadLine();
                    Console.WriteLine("Tester added.");
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                    Tester test = new Tester(sCompanyName, sEmployeeNumber, sName, sAddress);
                    testers.Add(test);
                }
                else if (sChoice == "4")
                {
                    // calls the method InfoPrinter to print the attributes of the objects that the user has created
                    // for loops that loop through the lists of programmers, testers and marketers
                    for (int i = 0; i < programmers.Count; i++)
                    {
                        programmers[i].InfoPrinter();
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                    }

                    for (int i = 0; i < marketers.Count; i++)
                    {
                        marketers[i].InfoPrinter();
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                    }

                    for (int i = 0; i < testers.Count; i++)
                    {
                        testers[i].InfoPrinter();
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                    }
                }
                else if (sChoice == "5")
                {
                    // calls and prints out the amount of objects in different categorys
                    Console.WriteLine("There are {0} programmers, {1} marketers and {2} testers.", Programmer.iCountProgrammers, Marketer.iCountMarketers, Tester.iCountTesters);
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                }
                else if (sChoice == "6")
                {
                    // Calls the method in this class that claculates the total amount of salary of the objects the user has created and prints it out
                    Console.WriteLine("The total salary cost is {0}", TotalSalaryCost());
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                }
                else if (sChoice == "0")
                {
                    // sets the running boolean to false and ends the program
                    Console.WriteLine("Thank you for using the program, the window will close when you press a button.");
                    Running = false;
                    
                }
                else
                {
                    // exception handling and an error message if the user tries to input something else in the menu than 0-6
                    Console.WriteLine("Invalid input, try again.");
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                }
            }
            


        }

        // method to count the total salary amount of the objects that has been inserted in the lists
        // uses the count of the objects and the private salary variable through the get-method that was created inside the sub-classes Programmer, Tester and Marketer
        // Creates a integer variable iTotalSalary that holds on to the total value and returns it
        internal int TotalSalaryCost()
        {
            int iTotalSalary = 0;
            for (int i = 0; i < programmers.Count; i++)
            {
                iTotalSalary = iTotalSalary + programmers[i].Salary;
            }

            for (int i = 0; i < marketers.Count; i++)
            {
                iTotalSalary = iTotalSalary + marketers[i].Salary;
            }

            for (int i = 0; i < testers.Count; i++)
            {
                iTotalSalary = iTotalSalary + testers[i].Salary;
            }

            return iTotalSalary;

        }

    }
}
