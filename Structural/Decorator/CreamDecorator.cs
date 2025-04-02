 
using System.Text;

namespace Decorator; 
    public class CreamDecorator : CoffeeDecorator //Concrete Decorator
    {
        public CreamDecorator(ICoffee coffee) : base(coffee) { }

        public override decimal Cost() => base.Cost() + 10;

        public override StringBuilder Description() => base.Description().Append(", Cream");

    } 

 