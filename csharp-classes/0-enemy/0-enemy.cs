using System;

namespace Enemies
{
    /// <summary>
    /// Defines a zombie enemy
    /// </summary>
    public class Zombie
    {
        // Empty class as requested
    }
}

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject = new Enemies.Zombie();

        Console.WriteLine("newObject is of type {0}", newObject.GetType());
        Console.WriteLine("String representation: {0}", newObject.ToString());
    }
}