using System;

class Program
{
    static void Main(string[] args)
    {
        float number = float.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Float: {0:F2}", number);
    }
}
