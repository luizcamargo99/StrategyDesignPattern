namespace StrategyDesignPattern
{
    internal class Sedex : ITransportationStrategy
    {
        public void CalculateFreight()
        {
            Console.WriteLine("Calcular usando Sedex");
        }
    }
}
