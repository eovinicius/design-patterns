namespace TemplateMethod;

public abstract class PaymentProcessor
{
    public void ProcessPayment()
    {
        ValidatePayment();
        DeductAmount();
        GenerateReceipt();
        NotifyUser();
    }

    protected abstract void ValidatePayment();
    protected abstract void DeductAmount();
    protected abstract void GenerateReceipt();
    protected abstract void NotifyUser();
}
