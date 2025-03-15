namespace Singleton;

public class OrderProcessor
{
    private readonly Logger _logger;

    public OrderProcessor(Logger logger)
    {
        _logger = logger;
    }

    public void Execute()
    {
        //logica para processar um pedido

        _logger.Log("Pedido processado!");
    }
}
