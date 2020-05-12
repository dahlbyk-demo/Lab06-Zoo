using System;

namespace Lab06_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my wacky zoo!");

            // All new animals created 
            Peacock peacock = new Peacock();
            Owl owl = new Owl();
            PolarBear polarBear = new PolarBear();
            Panther panther = new Panther();
            Tiger tiger = new Tiger();

            // Peacock properties and traits
            Console.WriteLine(peacock.Color);
            Console.WriteLine(peacock.Fly()); // Proof of inheritence as it reaches out to bird to acquire this method
            Console.WriteLine(peacock.Action());
            Console.WriteLine(peacock.Sound());
            Console.WriteLine(peacock.Sleep()); // Virtual method defined in animal base class
        }
    }
}
