namespace Strategy;

public class ShoppingCart
{
    private string _itemName;
    private decimal _price;

    private IPayment? _paymentStrategy;
    public ShoppingCart(string itemName, decimal price)
    {
        _itemName = itemName;
        _price = price; 
    }

    public void SetPaymentStrategy(IPayment payment)
    {
        _paymentStrategy = payment;
    }


    public void Pay()
    {
        if (this._paymentStrategy is null)
            throw new Exception("Payment method is not set");
            _paymentStrategy.Pay(_price);
    }
}