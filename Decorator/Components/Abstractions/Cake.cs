using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Components
{
    public abstract class Cake //Abstract class to be inherited by other classes
    {
        public virtual string Description { get; protected set; } = "Unknown Cake"; //Sets description to "Unknown Cake"

        public abstract double Calories(); //Declares the Calories variable
    }
}
