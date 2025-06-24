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
        private int health;

        /// <summary>
        /// Name of the zombie
        /// </summary>
        private string name = "(No name)";

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

        /// <summary>
        /// Gets or sets the name of the zombie
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets the health value of the zombie
        /// </summary>
        /// <returns>The current health of the zombie</returns>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>
        /// Returns a string representation of the zombie
        /// </summary>
        /// <returns>A formatted string with zombie name and health</returns>
        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
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
            newObject1.Name = "Ed";
            Console.WriteLine(newObject1.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(98);
            Console.WriteLine(newObject2.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}