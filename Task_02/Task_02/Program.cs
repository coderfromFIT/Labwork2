using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    public double ConvertToUsd(double amountInUah)
    {
        return amountInUah / usdRate;
    }

    public double ConvertToEur(double amountInUah)
    {
        return amountInUah / eurRate;
    }

    public double ConvertToPln(double amountInUah)
    {
        return amountInUah / plnRate;
    }

    public double ConvertFromUsd(double amountInUsd)
    {
        return amountInUsd * usdRate;
    }

    public double ConvertFromEur(double amountInEur)
    {
        return amountInEur * eurRate;
    }

    public double ConvertFromPln(double amountInPln)
    {
        return amountInPln * plnRate;
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the Converter class with specified currency rates
        Converter converter = new Converter(27.5, 32.1, 7.8);

        // Conversion from UAH to other currencies
        double amountInUah = 1000;
        Console.WriteLine($"{amountInUah} UAH to USD: {converter.ConvertToUsd(amountInUah)}");
        Console.WriteLine($"{amountInUah} UAH to EUR: {converter.ConvertToEur(amountInUah)}");
        Console.WriteLine($"{amountInUah} UAH to PLN: {converter.ConvertToPln(amountInUah)}");

        Console.WriteLine();

        // Conversion from other currencies to UAH
        double amountInUsd = 50;
        double amountInEur = 40;
        double amountInPln = 200;

        Console.WriteLine($"{amountInUsd} USD to UAH: {converter.ConvertFromUsd(amountInUsd)}");
        Console.WriteLine($"{amountInEur} EUR to UAH: {converter.ConvertFromEur(amountInEur)}");
        Console.WriteLine($"{amountInPln} PLN to UAH: {converter.ConvertFromPln(amountInPln)}");

        // Adding a command to keep the console from closing
        Console.ReadLine();
    }
}
