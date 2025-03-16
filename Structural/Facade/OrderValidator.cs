namespace Facade;

public class OrderValidator
{
    public bool Validate(Order order)
    {
        Console.WriteLine("Order validated successfully!");
        return true;
    }
}
