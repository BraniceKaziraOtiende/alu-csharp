using System;

public enum Rating
{
    Good = 0,
    Great = 1,
    Excellent = 2
}

class Program
{
    static void Main(string[] args)
    {
        // Change this line to test different cases:
        Rating rating = Rating.Great;  // For main_0.cs case
                                       // Rating rating = Rating.Good;     // For main_1.cs case  
                                       // Rating rating = Rating.Excellent; // For main_2.cs case

        Console.WriteLine("Score: " + rating);
        Console.WriteLine("Score: " + (int)rating);
    }
}