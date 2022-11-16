namespace StrategyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalculateShipping("DHL");
            TransportationContext transportationContext = new(new DHL());
            transportationContext.CalculateShipping();
        }

        // Without Strategy
        static void CalculateShipping(string type)
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