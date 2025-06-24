using System;

namespace Enemies
{
    public class Zombie
    {
        private int health;


        private string name = "(No name)";


        public Zombie()
        {
            health = 0;
        }

        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int GetHealth()
        {
            return health;
        }


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