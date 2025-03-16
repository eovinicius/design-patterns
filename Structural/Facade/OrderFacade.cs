namespace Facade;

class OrderFacade
{
    private readonly OrderValidator _validator;
    private readonly PaymentService _payment;
    private readonly InvoiceService _invoice;
    private readonly ShippingService _shipping;

    public OrderFacade()
    {
        _validator = new OrderValidator();
        _payment = new PaymentService();
        _invoice = new InvoiceService();
        _shipping = new ShippingService();
    }

    public void ProcessOrder(Order order)
    {
        if (!_validator.Validate(order)) return;
        if (!_payment.ProcessPayment(order)) return;

        _invoice.GenerateInvoice(order);
        _shipping.ShipOrder(order);

        Console.WriteLine("Order successfully processed!\n");
    }
}