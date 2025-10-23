using System.Text;

namespace Decorator;

public class MilkDecorator : CoffeeDecorator //Milk Decorator
{
    //Coffee _coffee;
    public MilkDecorator(ICoffee coffee)
        : base(coffee) { }

    public override decimal Cost() => base.Cost() + 15;

    public override StringBuilder Description() => _coffee.Description().Append(", Milk");
}

public class ChocolateChipsDecorator : CoffeeDecorator // Chocolate Chips Decorator
{
    public ChocolateChipsDecorator(ICoffee coffee)
        : base(coffee) { }

    public override decimal Cost() => base.Cost() + 35;

    public override StringBuilder Description() => base.Description().Append(", Chocolate Chips");
}
