using Decorator.Components;

namespace Decorator.Components
{
    public class Tart : Cake //Inherit from the abstract Cake class
    {
        public Tart() //Constructor function runs when an object of this class is created
        { 
            Description = "Tart"; //Sets the description to "Tart"
        }

        public override double Calories() //Update the calorie count
        {
            return 372; //372 calories in this tart
        }
    }
}


