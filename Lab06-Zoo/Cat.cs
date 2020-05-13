using System;

namespace Lab06_Zoo
{
    /// <summary>
    /// Abstract sub class of mammals defined here
    /// </summary>
    public abstract class Cat : Mammal
    {
        /// <summary>
        /// Abstract property of cats undefined here
        /// </summary>
        public abstract string Color { get; set; }

        /// <summary>
        /// Virtual method for cats defined here
        /// </summary>
        public virtual string Climb()
        {
            return "The feline species in our zoo love to climb!";
        }
    }
}
