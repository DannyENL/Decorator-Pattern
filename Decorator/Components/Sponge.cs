using Decorator.Components;

namespace Decorator.Components
{
    public class Sponge : Cake //Inherit from the abstract Cake class
    {
        public Sponge() //Constructor function runs when an object of this class is created
        {
            Description = "Sponge"; //Sets the description to "Sponge"
        }

        public override double Calories() //Update the calorie count
        {
            return 297; //297 calories in this sponge
        }
    }
}
