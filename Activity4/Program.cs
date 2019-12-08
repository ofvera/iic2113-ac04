using System;

namespace Activity4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Currency clp = new CLPCurrency(100000);
            // CurrencyExchange exchange = new Exchange1();
            
            // // Equivalent USD through Exchange1
            // var usd = exchange.Exchange(clp, "USD");
            // Console.WriteLine($"{clp.Value} CLP equals {usd.Value} USD through Exchange1.");

            Currency clp = new CLPCurrency(100000);
            CurrencyExchange exchange = new Exchange1();
            IConvertor pesoDolarConvertor = new ConvertPesoDolar();

            var usd = exchange.Exchange(clp, pesoDolarConvertor);
        }
    }
}