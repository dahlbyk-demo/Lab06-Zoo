namespace Lab06_Zoo
{
    abstract class Mammal : Animal
    {
        /// <summary>
        /// Virtual property for mammals defined here
        /// </summary>
        public virtual string Breeds { get; set; } = "Unsolicitously, and for everyone to see!";


    }
}
