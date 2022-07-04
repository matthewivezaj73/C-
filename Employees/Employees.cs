/*
    Matthew Ivezaj
    7/4/2022
    Employees
*/
//Creating a public class.
public class Employee
{
    //Adding private variables.
    private string alias;
    private string name;
    //Creating a public constructor.
    public Employee(string name, string employeeID)
    {
        //Qualifying the members of the class by using this.
        this.name = name;
        this.employeeID = employeeID;
    }
    //Creating a public method to acquire the employee information.
    public void getEmployeeData(string name, int employeeID)
    {
        //Printing out a message to the user.
        //Reading the line from the user as input.
    }
}