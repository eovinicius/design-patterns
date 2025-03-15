namespace Observer;

public class Bitcoin
{
    public decimal Price { get; private set; }
    public List<IBitcoinPriceObserver> Observers { get; private set; }
    public Bitcoin()
    {
        Observers = [];
    }

    public void SetPrice(decimal newPrice)
    {
        if (newPrice != Price)
        {
            Price = newPrice;
            NotifyObservers();
        }
    }

    public void AddObservers(IBitcoinPriceObserver observer)
    {
        Observers.Add(observer);
    }

    private void NotifyObservers()
    {
        foreach (var observer in Observers)
        {
            observer.Update(Price);
        }
    }
}