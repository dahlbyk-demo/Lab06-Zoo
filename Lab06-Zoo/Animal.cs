using System;

namespace Lab06_Zoo
{
    public abstract class Animal
    {
        /// <summary>
        /// Virtual property to be overridden in subsequent classes
        /// </summary>
        public virtual int NumberInPen { get; set; } = 2;

        public abstract bool IsFriendly { get; }

        /// <summary>
        /// Abstract methods to be overridden on next or subsequent layers
        /// </summary>
        public abstract string Action();
        public abstract string Sound();

        /// <summary>
        /// Virtual method to potentially be overridden down the line
        /// </summary>
        public virtual string Sleep()
        {
            return "This animal sleeps at night.";
        }

        public override string ToString()
        {
            return $"Animal: {GetType().Name}";
        }

        public void DisplayCard()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine("-------------------");
            Console.WriteLine($"Action: {Action()}");
            Console.WriteLine($"Sound: {Sound()}");
            Console.WriteLine($"Sleep: {Sleep()}");

            if (this is ICanFly flier)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine($"Flying Sound: {flier.FlyingSound()}");
                Console.WriteLine($"Coconuts?: {flier.CarryingCoconuts}");
            }

            AdditionalDisplay();

            Console.WriteLine("-------------------");
        }

        protected virtual void AdditionalDisplay()
        {
        }
    }
}
