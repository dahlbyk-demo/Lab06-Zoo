namespace Lab06_Zoo
{
    /// <summary>
    /// Concrete sub class 3 of 5,
    /// Direct sub class of mammal
    /// </summary>
    public class PolarBear : Mammal
    {
        public PolarBear()
            : base(900)
        {
        }

        /// <summary>
        /// The polar bears have bread so we have a litter of cubs here!
        /// </summary>
        public override int NumberInPen => 5;

        /// <summary>
        /// Abstract method override and example of polymorphism
        /// </summary>
        public override string Sound()
        {
            return "The polar bears grunt as they stumble over each other to cuddle you.";
        }
    }
}
