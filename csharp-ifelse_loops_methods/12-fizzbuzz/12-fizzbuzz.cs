using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Task 0: Positive or Negative");
        Task0_PositiveOrNegative();

        Console.WriteLine("\nTask 1: Last Digit");
        Task1_LastDigit();

        Console.WriteLine("\nTask 2: Print Alphabet");
        Task2_PrintAlphabet();

        Console.WriteLine("\nTask 3: Print Alphabet Without q and e");
        Task3_PrintAlphabetWithoutQE();

        Console.WriteLine("\nTask 4: Hexadecimal Printing");
        Task4_PrintHex();

        Console.WriteLine("\nTask 5: 00...99");
        Task5_Print00to99();
    }

    static void Task0_PositiveOrNegative()
    {
        Random rand = new Random();
        int number = rand.Next(-10000, 10000);
        Console.WriteLine($"{number} is " +
            (number > 0 ? "positive" : number == 0 ? "zero" : "negative"));
    }

    static void Task1_LastDigit()
    {
        Random rand = new Random();
        int number = rand.Next(-10000, 10000);
        int lastDigit = number % 10;

        Console.Write($"The last digit of {number} is {lastDigit} and is ");

        if (lastDigit > 5)
            Console.WriteLine("greater than 5");
        else if (lastDigit == 0)
            Console.WriteLine("0");
        else
            Console.WriteLine("less than 6 and not 0");
    }

    static void Task2_PrintAlphabet()
    {
        for (char c = 'a'; c <= 'z'; c++)
            Console.Write(c);
        Console.WriteLine();
    }

    static void Task3_PrintAlphabetWithoutQE()
    {
        for (char c = 'a'; c <= 'z'; c++)
        {
            if (c == 'q' || c == 'e')
                continue;
            Console.Write(c);
        }
        Console.WriteLine();
    }

    static void Task4_PrintHex()
    {
        for (int i = 0; i <= 98; i++)
            Console.WriteLine($"{i} = 0x{i:x}");
    }

    static void Task5_Print00to99()
    {
        for (int i = 0; i <= 99; i++)
        {
            if (i < 99)
                Console.Write($"{i:D2}, ");
            else
                Console.WriteLine($"{i:D2}");
        }
    }
}
