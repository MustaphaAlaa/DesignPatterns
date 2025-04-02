 
using System.Text;

namespace Decorator;
    public class ChocolateDecorator : CoffeeDecorator // Concrete Decorator
    {
        //Coffee _coffee;
        public ChocolateDecorator(ICoffee coffee) : base(coffee) { }

        public override decimal Cost() => base.Cost() + 10;
        public override StringBuilder Description() => base.Description().Append(", Chocolate");
    }
 