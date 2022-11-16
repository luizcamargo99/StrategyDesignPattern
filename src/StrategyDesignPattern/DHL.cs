namespace StrategyDesignPattern
{
    internal class DHL : ITransportationStrategy
    {
        public void CalculateFreight()
        {
            Console.WriteLine("Calcular usando DHL");
        }
    }
}
