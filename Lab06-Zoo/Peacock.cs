namespace Lab06_Zoo
{
    /// <summary>
    /// Concrete animal derivative class 1 of 5
    /// </summary>
    public class Peacock : Bird
    {
        // Private property for peacock color defined here
        private const string peacockColor = "Our peacocks are albino!";

        public Peacock()
        {
            NumberInPen = 25;
        }

        /// <summary>
        /// Abstract property overridden,
        /// Displays polymorphism between the owl and peacock, even though they're both white
        /// </summary>
        public override string Color { get => peacockColor; set => peacockColor.ToString(); }

        public override bool IsFriendly
        {
            get { return true; }
        }

        /// <summary>
        /// Abstract method overrides here
        /// </summary>
        public override string Action()
        {
            return "Both peacocks charge as you approach!";
        }

        public override string Sound()
        {
            return "The peacocks sound like they're laughing as you run away scared.";
        }
    }
}
