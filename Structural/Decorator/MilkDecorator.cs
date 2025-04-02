
using System.Text;

namespace Decorator;
public class MilkDecorator : CoffeeDecorator //Milk Decorator
{
    //Coffee _coffee;
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override decimal Cost() => base.Cost() + 15;



    public override StringBuilder Description() => _coffee.Description().Append(", Milk");

}
