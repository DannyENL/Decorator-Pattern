using System;
using Decorator.Components;
using Decorator.Decorators;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cake cake = new Tart(); //Create a new Tart object
            Console.WriteLine(cake.Description + " (" + cake.Calories() + " calories)"); //Display calorie count

            Cake cake2 = new Cupcake(); //Create a new Cupcake object
            cake2 = new Sprinkles(cake2); //Use the Sprinkles decorator
            Console.WriteLine(cake2.Description + " : " + cake2.Calories() + " calories"); //Display calorie count

            Cake cake3 = new Sponge(); //Create a new Sponge object
            cake3 = new Almonds(cake3); //Use the Almonds decorator
            cake3 = new Strawberry(cake3); //Use the Strawberry decorator
            Console.WriteLine(cake3.Description + " : " + cake3.Calories() + " calories"); //Display calorie count

        }
    }
}

