namespace Observer;

public interface IBitcoinPriceObserver
{
    void Update(decimal price);
}
