namespace StrategyDesignPattern;

internal class Program
{
    static void Main(string[] args)
    {
        TransportationContext transportationContext = new(new DHL());
        transportationContext.CalculateShipping();
    }
}