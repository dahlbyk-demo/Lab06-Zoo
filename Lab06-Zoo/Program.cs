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

            Console.WriteLine(Environment.NewLine);

            // Peacock properties and traits
            Console.WriteLine($"{peacock.Color}\n" +
                $"{peacock.NumberInPen}\n" +
                $"{peacock.Fly()}\n" +
                $"{peacock.Action()}\n" +
                $"{peacock.Sound()}\n" +
                $"{peacock.Sleep()}\n"
                );
            //Console.WriteLine(peacock.NumberInPen);
            //Console.WriteLine(peacock.Fly()); // Proof of inheritence as it reaches out to bird to acquire this method
            //Console.WriteLine(peacock.Action());
            //Console.WriteLine(peacock.Sound());
            //Console.WriteLine(peacock.Sleep()); // Virtual method defined in animal base class

            Console.WriteLine(Environment.NewLine);

            // Owl properties and traits
            Console.WriteLine(owl.Color);
            Console.WriteLine(owl.Fly());
            Console.WriteLine(owl.Action());
            Console.WriteLine(owl.Sound());
            Console.WriteLine(owl.Sleep()); // Polymorhphism and virtual method override

            Console.WriteLine(Environment.NewLine);

            // Polar properties and traits
            Console.WriteLine(polarBear.Breeds);
            Console.WriteLine($"There are {polarBear.NumberInPen} bears, 2 adults and 3 cubs."); // Animal virtual property, polymorphism
            Console.WriteLine(polarBear.Action());
            Console.WriteLine(polarBear.Sound());
            Console.WriteLine(polarBear.Sleep()); // Polymorhphism and virtual method override

            Console.WriteLine(Environment.NewLine);

            // Panther properties and traits
            Console.WriteLine(panther.Color);
            Console.WriteLine(panther.Sleep());
            Console.WriteLine(panther.Sound());
            Console.WriteLine(panther.Action());
            Console.WriteLine(panther.Climb());

            Console.WriteLine(Environment.NewLine);

            // Tiger properties and traits
            Console.WriteLine(tiger.Color);
            Console.WriteLine(tiger.Sleep());
            Console.WriteLine(tiger.Sound());
            Console.WriteLine(tiger.Action());
            Console.WriteLine(tiger.Climb());
        }
    }
}
