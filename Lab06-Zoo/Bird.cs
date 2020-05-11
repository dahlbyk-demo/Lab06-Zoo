using System;

namespace Lab06_Zoo
{
    public abstract class Bird : Animal
    {
        /// <summary>
        /// First of two required abstract properties written into the hierarchy of my classes
        /// </summary>
        public abstract string Color { get; set; }

        /// <summary>
        /// Virtual method for birds here
        /// </summary>
        public virtual void Fly()
        {
            Console.WriteLine("All of our birds know how to fly, but we will have penguins soon!");
        }
    }
}
