using System;

namespace Lab06_Zoo
{
    /// <summary>
    /// Concrete animal derivative class 1 of 5
    /// </summary>
    public class Peacock : Bird
    {
        private const string peacockColor = "Our peacocks are albino!";

        public override string Color { set => peacockColor; }

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
