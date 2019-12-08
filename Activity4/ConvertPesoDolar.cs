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
}