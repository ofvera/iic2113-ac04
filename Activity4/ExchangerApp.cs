using System;
namespace Activity4
{
    public class ExchangerApp
    {
        public bool End;
        public CurrencyExchange exchange1;
        public CurrencyExchange exchange2;
        public IConvertor pesoDolarConvertor;
        public IConvertor dolarPesoConvertor;
        public IConvertor dolarEuroConvertor;
        public IConvertor euroDolarConvertor;
        public IConvertor euroPesoConvertor;
        public IConvertor pesoEuroConvertor;

        public ExchangerApp()
        {
            exchange1 = new Exchange1();
            exchange2 = new Exchange2();
            pesoDolarConvertor = new ConvertPesoDolar();
            dolarPesoConvertor = new ConvertDolarPeso();
            dolarEuroConvertor = new ConvertDolarEuro();
            euroDolarConvertor = new ConvertEuroDolar();
            euroPesoConvertor = new ConvertEuroPeso();
            pesoEuroConvertor = new ConvertPesoEuro();
        }

        public void run()
        {
            Console.WriteLine("Welcome to Currency Exchanger!\n\n");
            End = false;
            while (!End)
            {
                Console.WriteLine("Menu\n1) View Exchange Rates\n2) Exchange Amount\n[Any Other Key] Quit");
                string menu = Console.ReadLine();
                if (menu == "1")
                {
                    Console.WriteLine("\nExchange Rates\n1) Exchange Rates 1\n2) Exchange Rates 2\n[Any Other Key] Back");
                    string rate = Console.ReadLine();
                    if (rate == "1")
                    {
                        Console.WriteLine(getRates(exchange1));
                    }
                    else if (rate == "2")
                    {
                        Console.WriteLine(getRates(exchange2));
                    }
                }
                else if (menu == "2")
                {
                    Console.WriteLine("\nChoose Exchange Rate\n1) Rate 1 \n2) Rate 2");
                    string rate = Console.ReadLine();
                    if (rate == "1")
                    {
                        ExchangeAmount(exchange1);
                    }
                    else if (rate == "2")
                    {
                        ExchangeAmount(exchange2);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Exchange Rate");
                    }
                }
                else
                {
                    End = true;
                    Console.WriteLine("\nGood Bye!");
                }
            }
        }

        public void ExchangeAmount(CurrencyExchange exchange)
        {
            Console.WriteLine("\nExchange From\n1) CLP \n2) USD\n3) EUR");
            string currency_from = Console.ReadLine();
            Console.WriteLine("\nExchange To\n1) CLP \n2) USD\n3) EUR");
            string currency_to = Console.ReadLine();
            if (currency_from != "1" && currency_from != "2" && currency_from != "3"
                && currency_to != "1" && currency_to != "2" && currency_to != "3")
            {
                Console.WriteLine("Invalid Exchange.. Try Again");
            }
            else if (currency_from == currency_to)
            {
                Console.WriteLine("No Exchange Selected");
            }
            else if (currency_from == "1")
            {
                Console.WriteLine("Insert Amount in CLP:");
                double amount = Convert.ToDouble(Console.ReadLine());
                Currency clp = new CLPCurrency(amount);
                if (currency_to == "2")
                {
                    var clp_usd = exchange.Exchange(clp, pesoDolarConvertor);
                    Console.WriteLine("Converted to USD: " + clp_usd.Value);
                }
                else
                {
                    var clp_eur = exchange.Exchange(clp, pesoEuroConvertor);
                    Console.WriteLine("Converted to EUR: " + clp_eur.Value);
                }
            }
            else if (currency_from == "2")
            {
                Console.WriteLine("Insert Amount in USD:");
                double amount = Convert.ToDouble(Console.ReadLine());
                Currency usd = new USDCurrency(amount);
                if (currency_to == "1")
                {
                    var usd_clp = exchange.Exchange(usd, dolarPesoConvertor);
                    Console.WriteLine("Converted to CLP: " + usd_clp.Value);
                }
                else
                {
                    var usd_eur = exchange.Exchange(usd, dolarEuroConvertor);
                    Console.WriteLine("Converted to EUR: " + usd_eur.Value);
                }
            }
            else if (currency_from == "3")
            {
                Console.WriteLine("Insert Amount in EUR:");
                double amount = Convert.ToDouble(Console.ReadLine());
                Currency eur = new EURCurrency(amount);
                if (currency_to == "1")
                {
                    var eur_clp = exchange.Exchange(eur, euroPesoConvertor);
                    Console.WriteLine("Converted to CLP: " + eur_clp.Value);
                }
                else
                {
                    var eur_usd = exchange.Exchange(eur, euroDolarConvertor);
                    Console.WriteLine("Converted to USD: " + eur_usd.Value);
                }
            }
            Console.WriteLine("");
        }

        public string getRates(CurrencyExchange exchange)
        {
            string rates = "1 USD <=> " + exchange.DolarClpRate + " CLP\n";
            rates += "1 EUR <=> " + exchange.EuroClpRate + " CLP\n";
            rates += "1 USD <=> " + exchange.DolarEuroRate + " EUR\n";
            return rates;
        }


    }
}
