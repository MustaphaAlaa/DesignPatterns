namespace Strategy;

public class CreditCardPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Credit Card Payment: {amount}");
    }
}
