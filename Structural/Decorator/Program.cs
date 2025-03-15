using Decorator;

var registerCustomer = new RegisterCustomerDecorator(new RegisterCustomer());
registerCustomer.Register();