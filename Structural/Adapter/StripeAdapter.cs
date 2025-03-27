namespace Adapter;

public class StripeAdapter : IPaymentProcessor
{
    //implementação usando stripe para processar o pagamento

    public bool ProcessPayment(decimal amount, string currency, string customerEmail)
    {

        //implementação usando stripe para processar o pagamento

        return new Random().Next(2) == 0;
    }
}
