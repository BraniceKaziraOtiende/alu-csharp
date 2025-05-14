using System;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        float number = 0;
        if (!float.TryParse(input, out number)) number = 0;
        Console.WriteLine("Float: {0:F2}", number);
    }
}
