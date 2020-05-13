namespace Lab06_Zoo
{
    /// <summary>
    /// Concrete class 5 of 5,
    /// Third layer of inheritence
    /// </summary>
    public class Tiger : Cat
    {
        // Private tiger property defined here
        private const string tigerColor = "Orange with black stripes";

        public Tiger(int mass) : base(mass)
        {
        }

        /// <summary>
        /// Abstract property override here
        /// </summary>
        public override string Color { get => tigerColor; set => tigerColor.ToString(); }

        /// <summary>
        /// Abstract method override here
        /// </summary>
        public override string Sound()
        {
            return "Rawr!";
        }
    }
}
