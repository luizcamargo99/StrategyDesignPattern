namespace StrategyDesignPattern;

internal class TransportationContext
{
    private readonly ITransportationStrategy _strategy;

    public TransportationContext(ITransportationStrategy strategy)
    {
        _strategy = strategy;
    }

    public void CalculateShipping()
    {
        _strategy.CalculateShipping();
    }
}
