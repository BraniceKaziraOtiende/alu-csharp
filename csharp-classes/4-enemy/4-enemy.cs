using System;

namespace Enemies
{
    /// <summary>
    /// Represents a zombie enemy.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Private field for zombie's health.
        /// </summary>
        private int health;

        /// <summary>
        /// Private field for zombie's name.
        /// </summary>
        private string name = "(No name)";

        /// <summary>
        /// Default constructor: Initializes health to 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Constructor with health parameter.
        /// </summary>
        /// <param name="value">Health value to initialize with.</param>
        /// <exception cref="ArgumentException">If value is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }

        /// <summary>
        /// Gets or sets the name of the zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Returns the health of the zombie.
        /// </summary>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>
        /// Overrides ToString() to print zombie's name and health.
        /// </summary>
        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}
