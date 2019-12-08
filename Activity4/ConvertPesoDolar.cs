namespace Activity4
{
    public class ConvertPesoDolar : IConvertor
    {
        public Currency ConvertForExchange1(Currency currency){
            return new USDCurrency(currency.Value / 791.16);
        }
        public Currency ConvertForExchange2(Currency currency){
            return new USDCurrency(currency.Value / 791.19);
        }
    }

    public class ConvertDolarPeso : IConvertor
    {
        public Currency ConvertForExchange1(Currency currency)
        {
            return new CLPCurrency(currency.Value * 791.16);
        }
        public Currency ConvertForExchange2(Currency currency)
        {
            return new CLPCurrency(currency.Value * 791.19);
        }
    }

    public class ConvertPesoEuro : IConvertor
    {
        public Currency ConvertForExchange1(Currency currency)
        {
            return new USDCurrency(currency.Value / 871.03);
        }
        public Currency ConvertForExchange2(Currency currency)
        {
            return new USDCurrency(currency.Value / 871.09);
        }
    }

    public class ConvertEuroPeso : IConvertor
    {
        public Currency ConvertForExchange1(Currency currency)
        {
            return new CLPCurrency(currency.Value * 871.03);
        }
        public Currency ConvertForExchange2(Currency currency)
        {
            return new CLPCurrency(currency.Value * 871.09);
        }
    }

    public class ConvertDolarEuro : IConvertor
    {
        public Currency ConvertForExchange1(Currency currency)
        {
            return new USDCurrency(currency.Value * 0.91);
        }
        public Currency ConvertForExchange2(Currency currency)
        {
            return new USDCurrency(currency.Value * 0.92);
        }
    }

    public class ConvertEuroDolar : IConvertor
    {
        public Currency ConvertForExchange1(Currency currency)
        {
            return new CLPCurrency(currency.Value / 0.91);
        }
        public Currency ConvertForExchange2(Currency currency)
        {
            return new CLPCurrency(currency.Value / 0.92);
        }
    }
}
