using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "Holberton School";
        Console.Write(str);  // Print the string 1st time without newline
        Console.Write(str);  // Print the string 2nd time without newline
        Console.Write(str);  // Print the string 3rd time without newline
        Console.WriteLine(str.Substring(0, 9));  // Print the first 9 characters with newline
    }
}
