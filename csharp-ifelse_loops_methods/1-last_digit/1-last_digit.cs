using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastnumber = number % 10;
        if (lastnumber > 5)
        {
            Console.WriteLine("This greater than 5");
        }
        else if (lastnumber == 0)
        {
            Console.WriteLine("THis equals to 0");
        }
        else
        {
            Console.WriteLine("and is less than 6 and not 0");
        }

    }
}