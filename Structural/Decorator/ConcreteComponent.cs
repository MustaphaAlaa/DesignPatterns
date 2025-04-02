 
using System.Text;

namespace Decorator;
public class TurkishCoffee : ICoffee //Concrete Component
{
    StringBuilder _description = new StringBuilder("Turkish Coffee");
    decimal _cost = 25;


    public virtual decimal Cost() => _cost;

    public virtual StringBuilder Description() => _description;
}



public class BrazilianCoffee : ICoffee //Concrete Component
{
    StringBuilder _description = new StringBuilder("Brazilian Coffee");
    decimal _cost = 20;


    public virtual decimal Cost() => _cost;

    public virtual StringBuilder Description() => _description;
 }



