namespace Activity4
{
    public class ConvertPesoDolar : IConvertor
    {
        public Currency ConvertForExchange1(CurrencyExchange exchange, Currency currency)
        {
            return new USDCurrency(currency.Value * exchange.ClpDolarRate);
        }

        public Currency ConvertForExchange2(CurrencyExchange exchange, Currency currency)
        {
            return new USDCurrency(currency.Value * exchange.ClpDolarRate);
        }
    }

    public class ConvertDolarPeso : IConvertor
    {
        public Currency ConvertForExchange1(CurrencyExchange exchange, Currency currency)
        {
            return new CLPCurrency(currency.Value * exchange.DolarClpRate);
        }

        public Currency ConvertForExchange2(CurrencyExchange exchange, Currency currency)
        {
            return new CLPCurrency(currency.Value * exchange.DolarClpRate);
        }
    }

    public class ConvertPesoEuro : IConvertor
    {
        public Currency ConvertForExchange1(CurrencyExchange exchange, Currency currency)
        {
            return new USDCurrency(currency.Value * exchange.ClpEuroRate);
        }

        public Currency ConvertForExchange2(CurrencyExchange exchange, Currency currency)
        {
            return new USDCurrency(currency.Value * exchange.ClpEuroRate);
        }
    }

    public class ConvertEuroPeso : IConvertor
    {
        public Currency ConvertForExchange1(CurrencyExchange exchange, Currency currency)
        {
            return new CLPCurrency(currency.Value * exchange.EuroClpRate);
        }

        public Currency ConvertForExchange2(CurrencyExchange exchange, Currency currency)
        {
            return new CLPCurrency(currency.Value * exchange.EuroClpRate);
        }
    }

    public class ConvertDolarEuro : IConvertor
    {
        public Currency ConvertForExchange1(CurrencyExchange exchange, Currency currency)
        {
            return new USDCurrency(currency.Value * exchange.DolarEuroRate);
        }

        public Currency ConvertForExchange2(CurrencyExchange exchange, Currency currency)
        {
            return new USDCurrency(currency.Value * exchange.DolarEuroRate);
        }
    }

    public class ConvertEuroDolar : IConvertor
    {
        public Currency ConvertForExchange1(CurrencyExchange exchange, Currency currency)
        {
            return new CLPCurrency(currency.Value * exchange.EuroDolarRate);
        }

        public Currency ConvertForExchange2(CurrencyExchange exchange, Currency currency)
        {
            return new CLPCurrency(currency.Value * exchange.EuroDolarRate);
        }
    }
}
