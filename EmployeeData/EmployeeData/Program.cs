/*
    Matthew Ivezaj
    7/4/2022
    Employees
*/
//Importing system.
using System;
//Creating a namespace.
namespace Employee {
    //Creating a public class.
    class Employee
    {
        //Adding private variables.
        private int employeeID;
        private string name;
        //Creating a public constructor.
        static void Main(String[] args)
        {
            //Qualifying the members of the class by using this.
            String name;
            int employeeID;

            //Printing out a message to the user.
            Console.WriteLine("Please enter the employee's name:   ");
            //Reading the line from the user as input.
            name = Console.ReadLine();

            //Pinting out a message to the user.
            Console.WriteLine("Please enter the employee's ID:   ");
            //Creating a console object.
            name = Console.ReadLine();
        }
    }
}