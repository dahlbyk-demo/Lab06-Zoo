using System;

namespace Lab06_Zoo
{
    /// <summary>
    /// Abstract sub class of animal and parent class to owls and peacocks
    /// </summary>
    public abstract class Bird : Animal, IFly
    {
        /// <summary>
        /// First of two required abstract properties written into the hierarchy of my classes
        /// </summary>
        public abstract string Color { get; set; }

        /// <summary>
        /// Virtual method for birds here
        /// </summary>
        public virtual string Fly()
        {
            return "All of our birds know how to fly, but we will have penguins soon!";
        }
    }
}
