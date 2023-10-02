using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate;

    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.registrationDate = DateTime.Now; // Initialization of the registration date
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"Login: {login}");
        Console.WriteLine($"First Name: {firstName}");
        Console.WriteLine($"Last Name: {lastName}");
        Console.WriteLine($"Age: {age} years");
        Console.WriteLine($"Registration Date: {registrationDate}");
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the User class
        User user = new User("john_doe", "John", "Doe", 25);

        // Displaying information about the user
        user.DisplayUserInfo();

        // Adding a command to keep the console from closing
        Console.ReadLine();
    }
}
