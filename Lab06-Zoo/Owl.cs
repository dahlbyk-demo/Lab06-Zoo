namespace Lab06_Zoo
{
    /// <summary>
    /// Concrete animal 2 of 5,
    /// The requirement for virutal method and property override are accomplished here
    /// </summary>
    public class Owl : Bird, ICanFly
    {
        // Private property for Color override
        private const string owlColor = "Our owls are snowy owls!";
        /// <summary>
        /// Abstract property is overridden here
        /// Displays polymorphism between the owl and peacock, even though they're both white
        /// </summary>
        public override string Color { get => owlColor; set => owlColor.ToString(); }

        /// <summary>
        /// Virtual property overridden here
        /// </summary>
        public override int NumberInPen => 1;

        public bool CarryingCoconuts => true;

        public override bool IsFriendly { get; } = false;

        /// <summary>
        /// Abstract methods overridden here
        /// </summary>
        public override string Action()
        {
            return "You imagine the owl swooping to snatch a mouse in the field, but only manage to find one sleeping.";
        }

        public string FlyingSound()
        {
            return "Whoooosh!";
        }

        public override string Sleep()
        {
            return "These birds sleep during the day and hunt at night!";
        }
        public override string Sound()
        {
            return "You hear the owl hoot as you walk by and disturb his sleep!";
        }
    }
}
