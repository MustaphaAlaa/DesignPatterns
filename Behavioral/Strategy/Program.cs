/*
    Init: Strategy is a behavioral design pattern that lets you define a family of algorithms,
        put each of them into a separate class, and make their objects interchangeable.

 The Strategy pattern suggests that you take a class that does something specific in a lot of different ways
  and extract all of these algorithms into separate classes called strategies.
*/

//!!! The Example is very Simple and not very useful, but it shows the concept of Strategy Pattern


using System.Runtime.InteropServices;
using Strategy;

ShoppingCart shoppingCart = new("Item1", 13900);

// shoppingCart.Pay(); //Exception: payment method isn't set

shoppingCart.SetPaymentStrategy(new CreditCardPayment());
shoppingCart.Pay();

shoppingCart.SetPaymentStrategy(new DeptCardPayment());
shoppingCart.Pay();

shoppingCart.SetPaymentStrategy(new CashPayment());
shoppingCart.Pay();