using System;

namespace Enemies
{
    /// <summary>
    /// Defines a zombie enemy
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Health of the zombie
        /// </summary>
        public int health;

        /// <summary>
        /// Constructor that initializes zombie health to 0
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject = new Enemies.Zombie();

        Console.WriteLine("newObject is of type {0} and has a total of {1} health", newObject.GetType(), newObject.health);
    }
}