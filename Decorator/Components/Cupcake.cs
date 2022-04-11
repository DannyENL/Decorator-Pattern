using Decorator.Components;

namespace Decorator.Components
{
    public class Cupcake : Cake //Inherit from the abstract Cake class
    {
        public Cupcake() //Constructor function runs when an object of this class is created
        {
            Description = "Cupcake"; //Sets the description to "Cupcake"
        }

        public override double Calories() //Update the calorie count
        {
            return 305; //305 calories in this cupcake
        }
    }
}


