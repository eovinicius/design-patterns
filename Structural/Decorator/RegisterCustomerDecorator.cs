namespace Decorator;

public class RegisterCustomerDecorator : IRegisterCustomer
{
    private readonly IRegisterCustomer _registerCustomer;

    public RegisterCustomerDecorator(IRegisterCustomer registerCustomer)
    {
        _registerCustomer = registerCustomer;
    }

    public void Register()
    {
        //logica adicional
        _registerCustomer.Register();
        //logica adicional
    }
}
