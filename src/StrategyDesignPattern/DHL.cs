namespace StrategyDesignPattern;

internal class DHL : ITransportationStrategy
{
    public void CalculateShipping()
    {
        Console.WriteLine("Calcular usando DHL");
    }
}
