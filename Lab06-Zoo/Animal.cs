using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo
{
    abstract class Animal
    {
        /// <summary>
        /// Virtual property to be overridden in subsequent classes
        /// </summary>
        public virtual int NumberInPen { get; set; } = 2;

        /// <summary>
        /// Abstract methods to be overridden on next or subsequent layers
        /// </summary>
        public abstract void Verb();
        public abstract void Sound();

        /// <summary>
        /// Virtual method to potentially be overridden down the line
        /// </summary>
        public virtual void Sleep()
        {
            Console.WriteLine("This animal sleeps at night.");
        }


    }
}
