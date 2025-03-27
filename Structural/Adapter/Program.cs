using Adapter;

IPaymentProcessor stripeAdapter = new StripeAdapter();

PaymentService paymentWithStripe = new PaymentService(stripeAdapter);

paymentWithStripe.MakePayment(200, "EUR", "johndoe@mail.com");