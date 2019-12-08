namespace Activity4
{
    public class ConvertPesoDolar : IConvertor
    {
        public Currency ConvertForExchange(CurrencyExchange exchange, Currency currency){
            return new USDCurrency(currency.Value * exchange.clpDolarRate);
        }
    }

    public class ConvertDolarPeso : IConvertor
    {
        public Currency ConvertForExchange(CurrencyExchange exchange, Currency currency)
        {
            return new CLPCurrency(currency.Value * exchange.dolarClpRate);
        }
    }

    public class ConvertPesoEuro : IConvertor
    {
        public Currency ConvertForExchange(CurrencyExchange exchange, Currency currency)
        {
            return new USDCurrency(currency.Value * exchange.clpEuroRate);
        }
    }

    public class ConvertEuroPeso : IConvertor
    {
        public Currency ConvertForExchange(CurrencyExchange exchange, Currency currency)
        {
            return new CLPCurrency(currency.Value * exchange.euroClpRate);
        }
    }

    public class ConvertDolarEuro : IConvertor
    {
        public Currency ConvertForExchange(CurrencyExchange exchange, Currency currency)
        {
            return new USDCurrency(currency.Value * exchange.dolarEuroRate);
        }
    }

    public class ConvertEuroDolar : IConvertor
    {
        public Currency ConvertForExchange(CurrencyExchange exchange, Currency currency)
        {
            return new CLPCurrency(currency.Value * exchange.euroDolarRate);
        }
    }
}
