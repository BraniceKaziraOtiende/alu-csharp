using System;

class Program
{
    static void Main(string[] args)
    {
        string output = "";
        for (int i = 0; i < 99; i++)
        {
            output += $"{i} : {i:x}\n";
        }
        Console.Write(output);
    }
}
