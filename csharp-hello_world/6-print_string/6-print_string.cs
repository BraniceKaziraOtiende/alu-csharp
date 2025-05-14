using System;
class Program
{
    static void Main(string[] args)
    {
        string str = "Holberton School";
        Console.WriteLine(str);  // Print the string 1st time
        Console.WriteLine(str);  // Print the string 2nd time
        Console.WriteLine(str);  // Print the string 3rd time
        Console.WriteLine(str.Substring(0, 9));  // Print the first 9 characters
    }
}
