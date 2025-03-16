namespace Facade;

public class ShippingService
{
    public void ShipOrder(Order order)
    {
        Console.WriteLine($"Order shipped to {order.Customer}.");
    }
}
