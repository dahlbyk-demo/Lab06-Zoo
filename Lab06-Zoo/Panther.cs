using System;

namespace Lab06_Zoo
{
    /// <summary>
    /// Concrete animal sub class 4 of 5,
    /// Third level of inheritance achieved here
    /// </summary>
    public class Panther : Cat
    {
        public Panther() : base(300) { }

        // Private property for color defined here
        private const string pantherColor = "Our panthers are a sleek, sheer black.";
        /// <summary>
        /// Abstract property override here,
        /// Another example of polymorphism from tigers
        /// </summary>
        public override string Color { get => pantherColor; set => pantherColor.ToString(); }

        /// <summary>
        /// Abstract method override here
        /// </summary>
        public override string Sound()
        {
            return "You hear a high pitched snarl coming from the shadows.";
        }

        /// <summary>
        /// Abstract method re-overidden deeper in the inheritence
        /// </summary>
        public override string Action()
        {
            return "These animals aren't the cuddly type cats...";
        }

        /// <summary>
        /// Virtual method override here
        /// </summary>
        public override string Climb()
        {
            return "You see the speed of the panther climbing a tree to peer down on you.";
        }

        public override string Sleep()
        {
            return "This animal hunts at night.";
        }


        protected override void AdditionalDisplay()
        {
            base.AdditionalDisplay();

            Console.WriteLine("Rawr is my favorite band");
        }
    }
}
