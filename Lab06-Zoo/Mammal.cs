using System;

namespace Lab06_Zoo
{
    public abstract class Mammal : Animal
    {
        /// <summary>
        /// Virtual property for mammals defined here
        /// </summary>
        public virtual string Breeds { get; set; } = "Unsolicitously, and for everyone to see!";

        /// <summary>
        /// Abstract method overridden here but a mammal doesn't know what sound it makes. See farther down the inheritance for this abstract override of the sound method.
        /// </summary>
        public override void Action()
        {
            Console.WriteLine("Mammals are cuddly animals! Come check it out for yourself!");
        }
    }
}
