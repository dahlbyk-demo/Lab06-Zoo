using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo
{
    public abstract class Animal
    {
        /// <summary>
        /// Virtual property to be overridden in subsequent classes
        /// </summary>
        public virtual int NumberInPen { get; set; } = 2;

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
    }
}
