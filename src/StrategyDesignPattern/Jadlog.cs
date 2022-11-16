namespace StrategyDesignPattern;

internal class Jadlog : ITransportationStrategy
{
    public void CalculateShipping()
    {
        Console.WriteLine("Calcular usando Jadlog");
    }
}
