using System;

namespace Cats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try out your skills with inheritance here!

            HouseCat garfield = new HouseCat("Garfield", 12.0);
            garfield.Eat();
            Console.WriteLine(garfield.Tired);

            HouseCat spike = new HouseCat("Spike");
            Console.WriteLine(spike.Weight);

            Cat plainCat = new Cat(8.6);
            HouseCat cheshireCat = new HouseCat("Cheshire Cat", 26.0);

            Console.WriteLine(plainCat.Noise());
            Console.WriteLine(cheshireCat.Noise());
        }
    }
}
