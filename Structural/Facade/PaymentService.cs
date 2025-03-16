namespace Facade;

public class PaymentService
{
    public bool ProcessPayment(Order order)
    {
        Console.WriteLine($"Payment of ${order.TotalAmount} approved!");
        return true;
    }
}
