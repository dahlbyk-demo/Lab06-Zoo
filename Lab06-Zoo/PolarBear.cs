using System;

namespace Lab06_Zoo
{
    /// <summary>
    /// Concrete sub class 3 of 5,
    /// Direct sub class of mammal
    /// </summary>
    public class PolarBear : Mammal, IFly
    {
        /// <summary>
        /// The polar bears have bread so we have a litter of cubs here!
        /// </summary>
        public override int NumberInPen => 5;

        /// <summary>
        /// Interface implemented here
        /// </summary>
        /// <returns></returns>
        public string Fly()
        {
            return "Polar bears with wings!";
        }

        /// <summary>
        /// Abstract method override and example of polymorphism
        /// </summary>
        public override string Sound()
        {
            return "The polar bears grunt as they stumble over each other to cuddle you.";
        }
    }
}
