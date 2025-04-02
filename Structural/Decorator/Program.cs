/*
***Key Components of the Decorator Design Pattern
 
   - Component Interface.
   - Concrete Component.
   - Base Decorator.
   - Concrete Decorator.
 
    1- The base Component interface defines operations that can be altered by decorators.
    2- Concrete Components provide default implementations of the operations.
       There might be several variations of these classes.
    3- The base Decorator class follows the same interface as the other components.
*/
using Decorator;


ICoffee coffee = new TurkishCoffee();
CoffeeDecorator coffeeDecorator = new MilkDecorator(coffee);
coffeeDecorator = new CreamDecorator(coffeeDecorator);
coffeeDecorator = new ChocolateDecorator(coffeeDecorator);
coffeeDecorator = new VanillaFlavorDecorator(coffeeDecorator);

Console.WriteLine(coffeeDecorator);

Console.WriteLine("\n\n\n\n\n");

coffee = new BrazilianCoffee();
coffeeDecorator = new MilkDecorator(coffee);
coffeeDecorator = new CreamDecorator(coffeeDecorator);
coffeeDecorator = new ChocolateDecorator(coffeeDecorator);

Console.WriteLine(coffeeDecorator);

