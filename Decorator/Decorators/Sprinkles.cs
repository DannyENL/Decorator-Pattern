using Decorator.Components;
using Decorator.Decorators;

namespace Decorator.Decorators
{
    public class Sprinkles : ToppingDecorator //Inherits from the ToppingDecorator class
    {
        private readonly Cake _cake; //Declare private variable _cake as a Cake object

        public Sprinkles(Cake cake) //Constructor function runs when an object of this class is created
        {
            _cake = cake; //Sets the private _cake variable to the Cake object given in the constructor function
        }

        public override double Calories() //Override the inherited Calories() function so that we can add the topping's calorie count
        {
            return 30 + _cake.Calories(); //Add 30 to the cake's calorie count
        }

        public override string Description => _cake.Description + " with sprinkles"; //Adds "with sprinkles" to the end of the cake's description
    }
}


