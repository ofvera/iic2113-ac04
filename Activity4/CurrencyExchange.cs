namespace Activity4
{
    public abstract class CurrencyExchange
    {
        public abstract double DolarClpRate { get; }
        public abstract double ClpDolarRate { get; }
        public abstract double EuroClpRate { get; }
        public abstract double ClpEuroRate { get; }
        public abstract double DolarEuroRate { get; }
        public abstract double EuroDolarRate { get; }

        // public abstract Currency Exchange(Currency from, string to);
        public abstract Currency Exchange(Currency from, IConvertor currencyConvertor);
    }
}