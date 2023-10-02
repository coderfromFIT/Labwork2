using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the Address class
        Address address = new Address();

        // Recording information about the address in the instance fields
        address.Index = "12023";
        address.Country = "Ukraine";
        address.City = "Kyiv";
        address.Street = "Kioto 27 street";
        address.House = "1";
        address.Apartment = "10";

        // Displaying the values of the address fields on the screen
        Console.WriteLine($"Index: {address.Index}");
        Console.WriteLine($"Country: {address.Country}");
        Console.WriteLine($"City: {address.City}");
        Console.WriteLine($"Street: {address.Street}");
        Console.WriteLine($"House: {address.House}");
        Console.WriteLine($"Apartment: {address.Apartment}");

        // Adding a command to keep the console from closing
        Console.ReadLine();
    }
}