﻿using System;

namespace Enemies
{
    /// <summary>
    /// Represents a zombie enemy.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Represents the health of the zombie.
        /// </summary>
        public int health;

        /// <summary>
        /// Initializes a new instance of the Zombie class with 0 health.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Zombie class with a specified health value.
        /// </summary>
        /// <param name="value">The initial health value of the zombie.</param>
        /// <exception cref="ArgumentException">Thrown when value is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }
    }
}
