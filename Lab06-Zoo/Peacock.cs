using System;

namespace Lab06_Zoo
{
    /// <summary>
    /// Concrete animal derivative class 1 of 5
    /// </summary>
    public class Peacock : Bird
    {
        // Private property for peacock color defined here
        private const string peacockColor = "Our peacocks are albino!";

        /// <summary>
        /// Abstract property overridden,
        /// Displays polymorphism between the owl and peacock, even though they're both white
        /// </summary>
        public override string Color { get => peacockColor;  set => peacockColor.ToString(); }


        /// <summary>
        /// Abstract method overrides here
        /// </summary>
        public override void Action()
        {
            Console.WriteLine("Both peacock charges as you approach!");
        }

        public override void Sound()
        {
            Console.WriteLine("The peacock sounds like it's laughing as you run away scared.");
        }
    }
}
