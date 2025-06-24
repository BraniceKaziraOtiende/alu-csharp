using System;

namespace Enemies
{

    public class Zombie
    {

        public int health;


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