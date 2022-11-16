namespace StrategyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalculateFreight("DHL");
            TransportationContext transportationContext = new(new DHL());
            transportationContext.CalculateFreight();
        }

        // Without Strategy
        static void CalculateFreight(string type)
        {
            if (type == "Sedex")
            {
                Console.WriteLine("Calcular usando Sedex");
            }
            else if (type == "DHL")
            {
                Console.WriteLine("Calcular usando DHL");
            }
            else if (type == "Jadlog")
            {
                Console.WriteLine("Calcular usando Jadlog");
            }
        }


    }
}