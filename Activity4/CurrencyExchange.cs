namespace Activity4
{
    public abstract class CurrencyExchange
    {
        // public abstract Currency Exchange(Currency from, string to);
        public abstract Currency Exchange(Currency from, IConvertor currencyConvertor);
    }
}