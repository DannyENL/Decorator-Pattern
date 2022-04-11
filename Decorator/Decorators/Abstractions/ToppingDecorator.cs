using Decorator.Components;

namespace Decorator.Decorators
{
    public abstract class ToppingDecorator : Cake //Abstract class to be inherited by other classes
    {
        public abstract override string Description { get; } 
    }
}


