namespace TemplateMethod;

public class CreditCardPayment : PaymentProcessor
{
    protected override void ValidatePayment() => Console.WriteLine("Validando cartão de crédito...");
    protected override void DeductAmount() => Console.WriteLine("Debitando valor do cartão...");
    protected override void GenerateReceipt() => Console.WriteLine("Gerando recibo do pagamento com cartão...");
    protected override void NotifyUser() => Console.WriteLine("Enviando notificação do pagamento via e-mail...");
}
