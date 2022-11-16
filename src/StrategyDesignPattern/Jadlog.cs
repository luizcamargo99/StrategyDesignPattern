namespace StrategyDesignPattern
{
    internal class Jadlog : ITransportationStrategy
    {
        public void CalculateFreight()
        {
            Console.WriteLine("Calcular usando Jadlog");
        }
    }
}
