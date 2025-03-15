using TemplateMethod;

PaymentProcessor payment = new CreditCardPayment();
payment.ProcessPayment();

Console.WriteLine("\n---\n");

payment = new PixPayment();
payment.ProcessPayment();