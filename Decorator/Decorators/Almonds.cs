using Decorator.Components;
using Decorator.Decorators;

namespace Decorator.Decorators
{
    public class Almonds : ToppingDecorator //Inherits from the ToppingDecorator class
    {
        private readonly Cake _cake; //Declare private variable _cake as a Cake object

        public Almonds(Cake cake) //Constructor function runs when an object of this class is created
        {
            _cake = cake; //Sets the private _cake variable to the Cake object given in the constructor function
        }

        public override double Calories() //Override the inherited Calories() function so that we can add the topping's calorie count
        {
            return 7 + _cake.Calories(); //Add 7 to the cake's calorie count
        }

        public override string Description => _cake.Description + " with almonds"; //Adds "with almonds" to the end of the cake's description
    }
}


