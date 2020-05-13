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

            // Peacock methods and properties
            Console.WriteLine($"{peacock.Color}\n" +
                $"{peacock.Fly()}\n" +// Proof of inheritence as it reaches out to bird to acquire this method
                $"{peacock.Action()}\n" +
                $"{peacock.Breed()}\n" +
                $"{peacock.Sleep()}\n"// Virtual method defined in animal base class
                );

            // Owl methods and properties
            Console.WriteLine($"{owl.Color}\n" +
                $"{owl.Fly()}\n" +
                $"{owl.Action()}\n" +
                $"{owl.Sound()}\n" +
                $"{owl.Sleep()}\n"// Polymorhphism and virtual method override
                );

            // Polar bear methods and properties
            Console.WriteLine($"{polarBear.Breed()}\n" +
                $"{polarBear.Fly()}\n" +
                $"{polarBear.Action()}\n" +
                $"{polarBear.Sound()}\n" +
                $"{polarBear.Sleep()}\n"
                );

            // Panther methods and properties
            Console.WriteLine($"{panther.Color}\n" +
                $"{panther.Climb()}\n" +
                $"{panther.Action()}\n" +
                $"{panther.Sound()}\n" +
                $"{panther.Sleep()}\n"
                );

            // Tiger methods and properties
            Console.WriteLine($"{tiger.Color}\n" +
                $"{tiger.Climb()}\n" +
                $"{tiger.Action()}\n" +
                $"{tiger.Sound()}\n" +
                $"{tiger.Sleep()}\n"
                );

        }
    }
}
