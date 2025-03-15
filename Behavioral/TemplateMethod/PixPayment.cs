namespace TemplateMethod;

class PixPayment : PaymentProcessor
{
    protected override void ValidatePayment() => Console.WriteLine("Validando chave PIX...");
    protected override void DeductAmount() => Console.WriteLine("Transferindo dinheiro via PIX...");
    protected override void GenerateReceipt() => Console.WriteLine("Gerando comprovante PIX...");
    protected override void NotifyUser() => Console.WriteLine("Enviando notificação via WhatsApp...");
}
