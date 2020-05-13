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

            Console.WriteLine(Environment.NewLine);

            // Peacock properties and traits
            Console.WriteLine($"{peacock.Color}\n" +
                $"{peacock.Fly()}\n" +// Proof of inheritence as it reaches out to bird to acquire this method
                $"{peacock.Action()}\n" +
                $"{peacock.Sound()}\n" +
                $"{peacock.Sleep()}\n"// Virtual method defined in animal base class
                );

            Console.WriteLine($"{owl.Color}\n" +
                $"{owl.Fly()}\n" +
                $"{owl.Action()}\n" +
                $"{owl.Sound()}\n" +
                $"{owl.Sleep()}\n"// Polymorhphism and virtual method override
                );

            Console.WriteLine($"{owl.Color}\n" +
                $"{owl.Fly()}\n" +
                $"{owl.Action()}\n" +
                $"{owl.Sound()}\n" +
                $"{owl.Sleep()}\n"
                );
        }
    }
}
