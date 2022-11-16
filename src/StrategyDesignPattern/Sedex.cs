namespace StrategyDesignPattern
{
    internal class Sedex : ITransportationStrategy
    {
        public void CalculateShipping()
        {
            Console.WriteLine("Calcular usando Sedex");
        }
    }
}
