 
using System.Text;

namespace Decorator; 
 public abstract class CoffeeDecorator : ICoffee //Base decorator
    {
        protected ICoffee _coffee;
        public CoffeeDecorator(ICoffee coffee) => _coffee = coffee;

        public virtual decimal Cost() => _coffee.Cost();
        public virtual StringBuilder Description() => _coffee.Description();

        public override string ToString() => $"Description: {Description()} ####### Cost: {Cost()}";

    }
 

 