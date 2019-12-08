using System;

namespace Activity4
{
    class Program
    {
        
        static void Main(string[] args)
        {

            // UNCOMMENT FOR SIMPLE TEST

            // Currency clp = new CLPCurrency(100000);
            // Currency usd = new USDCurrency(300);
            // Currency eur = new EURCurrency(400);
            // CurrencyExchange exchange1 = new Exchange1();
            // CurrencyExchange exchange2 = new Exchange2();
            // IConvertor pesoDolarConvertor = new ConvertPesoDolar();
            // IConvertor dolarEuroConvertor = new ConvertDolarEuro();
            // IConvertor euroPesoConvertor = new ConvertEuroPeso();
            // var clp_usd = exchange1.Exchange(clp, pesoDolarConvertor);
            // var usd_eur = exchange1.Exchange(usd, dolarEuroConvertor);
            // var eur_clp = exchange1.Exchange(eur, euroPesoConvertor);
            // Console.WriteLine("Used Exchange1 from CLP: " + clp.Value + " to USD: " + clp_usd.Value);
            // Console.WriteLine("Used Exchange1 from USD: " + usd.Value + " to EUR: " + usd_eur.Value);
            // Console.WriteLine("Used Exchange1 from EUR: " + eur.Value + " to CLP: " + eur_clp.Value);

            // Terminal App
            ExchangerApp App = new ExchangerApp();
            App.run();
        }
    }
}