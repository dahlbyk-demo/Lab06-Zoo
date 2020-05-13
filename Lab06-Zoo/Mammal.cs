using System;

namespace Lab06_Zoo
{
    public abstract class Mammal : Animal
    {
        // public Mammal() { }

        protected Mammal(int mass)
        {
            this.Mass = mass;
        }

        /// <summary>
        /// Virtual property for mammals defined here
        /// </summary>
        public virtual string Breeds { get; set; } = "Breeds unsolicitously, and for everyone to see!";
        public int Mass { get; }

        /// <summary>
        /// Abstract method overridden here but a mammal doesn't know what sound it makes. See farther down the inheritance for this abstract override of the sound method.
        /// </summary>
        public override string Action()
        {
            return "Mammals are cuddly animals! Come check it out for yourself!";
        }

        protected override void AdditionalDisplay()
        {
            Console.WriteLine("I like milk");
        }

        public new string ToString()
        {
            return $"Mammal: {GetType().Name}";
        }

        public new void DisplayCard()
        {
            Console.WriteLine("This is a Mammal Card!");
            Console.WriteLine("My Breeds are: " + Breeds);
        }
    }
}
