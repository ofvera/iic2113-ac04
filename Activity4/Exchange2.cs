namespace Activity4
{
    // Esto no compila :(
    public class Exchange2 : CurrencyExchange
    {
        public override double dolarClpRate { get => 791.16; }
        public override double clpDolarRate { get => 1 / dolarClpRate; }
        public override double euroClpRate { get => 871.03; }
        public override double clpEuroRate { get => 1 / euroClpRate; }
        public override double dolarEuroRate { get => 0.91; }
        public override double euroDolarRate { get => 1 / dolarEuroRate; }

        public override Currency Exchange(Currency from, IConvertor currencyConvertor){
            return currencyConvertor.ConvertForExchange(this, from);
        }
        // public override Currency Exchange(CLPCurrency from, string to)
        // {
        //     if (to == "USD")
        //     {
        //         return new USDCurrency(from.Value / 791.19);
        //     } 
            
        //     if (to == "EUR")
        //     {
        //         return new EURCurrency(from.Value / 871.09);
        //     } 
            
        //     if (to == "CLP")
        //     {
        //         return new CLPCurrency(from.Value);
        //     }

        //     throw new InvalidCurrencyTypeException();
        // }
        
        // public override Currency Exchange(USDCurrency from, string to)
        // {
        //     if (to == "USD")
        //     {
        //         return new USDCurrency(from.Value);
        //     } 
            
        //     if (to == "EUR")
        //     {
        //         return new EURCurrency(from.Value * 0.92);
        //     } 
            
        //     if (to == "CLP")
        //     {
        //         return new CLPCurrency(from.Value * 791.19);
        //     }

        //     throw new InvalidCurrencyTypeException();
        // }
        
        // public override Currency Exchange(EURCurrency from, string to)
        // {
        //     if (to == "USD")
        //     {
        //         return new USDCurrency(from.Value / 0.92);
        //     } 
            
        //     if (to == "EUR")
        //     {
        //         return new EURCurrency(from.Value);
        //     } 
            
        //     if (to == "CLP")
        //     {
        //         return new CLPCurrency(from.Value * 871.09);
        //     }

        //     throw new InvalidCurrencyTypeException();
        // }
    }
}