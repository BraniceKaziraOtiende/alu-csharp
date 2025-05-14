using System;
class Program
{
    static void Main(string[] args)
    {
        double percent = .7553;
        double currency = 98765.4321;

        Console.WriteLine("Percent: {0:p2}", percent);  // Displays the percentage with 2 decimal places
        Console.WriteLine("Currency: {0:C2}", currency);    // Displays the currency in the correct format
    }
}
