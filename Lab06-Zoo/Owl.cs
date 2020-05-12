using System;

namespace Lab06_Zoo
{
    /// <summary>
    /// Concrete animal 2 of 5,
    /// The requirement for virutal method and property override are accomplished here
    /// </summary>
    public class Owl : Bird
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

        /// <summary>
        /// Abstract methods overridden here
        /// </summary>
        public override string Action()
        {
            return "You imagine the owl swooping to snatch a mouse in the field, but only find one manage to see one sleeping.";
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
