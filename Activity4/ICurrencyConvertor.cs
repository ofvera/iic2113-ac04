namespace Activity4
{
    public interface IConvertor
    {
        public Currency ConvertForExchange1(CurrencyExchange exchange,Currency currency);
        public Currency ConvertForExchange2(CurrencyExchange exchange, Currency currency);
    }
}