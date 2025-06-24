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

        /// <summary>
        /// Constructor that initializes zombie health to a specific value
        /// </summary>
        /// <param name="value">The initial health value</param>
        /// <exception cref="ArgumentException">Thrown when value is less than 0</exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            Console.WriteLine("newObject1 is of type {0} and has a total of {1} health", newObject1.GetType(), newObject1.health);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(-10);
            Console.WriteLine("newObject2 is of type {0} and has a total of {1} health", newObject2.GetType(), newObject2.health);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}