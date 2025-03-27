namespace Adapter;

public interface IPaymentProcessor
{
    bool ProcessPayment(decimal amount, string currency, string customerEmail);
}
