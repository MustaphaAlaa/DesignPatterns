namespace Strategy;

public class CashPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Cash Payment: {amount}");
    }
}