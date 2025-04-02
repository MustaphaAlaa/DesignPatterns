 
using System.Text;

namespace Decorator
{
    public class VanillaFlavorDecorator : CoffeeDecorator
    {
        //Coffee _coffee;
        public VanillaFlavorDecorator(ICoffee coffee) : base(coffee) { }

        public override decimal Cost() => base.Cost() + 10;
        public override StringBuilder Description() => base.Description().Append(", Vanilla Flavor");

    }
}

 