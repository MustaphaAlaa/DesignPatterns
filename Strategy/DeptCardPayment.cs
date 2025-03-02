namespace Strategy;

public class DeptCardPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Dept Card Payment: {amount}");
    }
}
