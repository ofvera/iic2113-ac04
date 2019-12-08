namespace Activity4
{
    public abstract class CurrencyExchange
    {
        public abstract double dolarClpRate { get; }
        public abstract double clpDolarRate { get; }
        public abstract double euroClpRate { get; }
        public abstract double clpEuroRate { get; }
        public abstract double dolarEuroRate { get; }
        public abstract double euroDolarRate { get; }

        // public abstract Currency Exchange(Currency from, string to);
        public abstract Currency Exchange(Currency from, IConvertor currencyConvertor);
    }
}