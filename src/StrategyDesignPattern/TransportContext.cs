namespace StrategyDesignPattern
{
    internal class TransportationContext
    {
        private readonly ITransportationStrategy _strategy;

        public TransportationContext(ITransportationStrategy strategy)
        {
            _strategy = strategy;
        }

        public void CalculateFreight()
        {
            _strategy.CalculateFreight();
        }
    }
}
