using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void CalculateSalary(string position, int experience)
    {
        double baseSalary = 0;

        // Determining salary based on position and experience
        switch (position.ToLower())
        {
            case "manager":
                baseSalary = 50000;
                break;
            case "developer":
                baseSalary = 60000;
                break;
            case "designer":
                baseSalary = 55000;
                break;
            // Additional cases for other positions can be added here
            default:
                Console.WriteLine("Unknown position");
                return;
        }

        // Additional bonus for experience
        double experienceBonus = experience * 1000;

        double totalSalary = baseSalary + experienceBonus;

        // Tax calculation (just an example, more complex rules can be applied)
        double tax = totalSalary * 0.15;

        // Displaying information about the employee
        Console.WriteLine($"Last Name: {lastName}");
        Console.WriteLine($"First Name: {firstName}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Base Salary: {baseSalary:C}");
        Console.WriteLine($"Experience Bonus: {experienceBonus:C}");
        Console.WriteLine($"Total Salary: {totalSalary:C}");
        Console.WriteLine($"Tax: {tax:C}");
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the Employee class
        Employee employee = new Employee("Smith", "John");

        // Calling the method to calculate salary and display information
        employee.CalculateSalary("developer", 5);

        // Adding a command to keep the console from closing
        Console.ReadLine();
    }
}
