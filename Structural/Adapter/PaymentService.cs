namespace Adapter;

public class PaymentService
{
    private readonly IPaymentProcessor _paymentProcessor;

    public PaymentService(IPaymentProcessor paymentProcessor)
    {
        _paymentProcessor = paymentProcessor;
    }

    public void MakePayment(decimal amount, string currency, string email)
    {
        bool success = _paymentProcessor.ProcessPayment(amount, currency, email);
        Console.WriteLine(success ? "Pagamento concluído com sucesso!" : "Falha no pagamento.");
    }
}

