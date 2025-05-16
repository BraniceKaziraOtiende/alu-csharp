using System;

class Program
{
    static void Main(string[] args)
    {
        string output = "";
        for (int i = 0; i < 99; i++)
        {
            output += $"{i} = 0x{i:x}\n";
        }
        Console.Write(output);
    }
}
