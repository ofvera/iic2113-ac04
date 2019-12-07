using System;

namespace Activity4
{
    // Esto no compila :(
    public class Exchange1 : CurrencyExchange
    {
        public override Currency Exchange(CLPCurrency from, string to)
        {
            if (to == "USD")
            {
                return new USDCurrency(from.Value / 791.16);
            } 
            
            if (to == "EUR")
            {
                return new EURCurrency(from.Value / 871.03);
            } 
            
            if (to == "CLP")
            {
                return new CLPCurrency(from.Value);
            }

            throw new InvalidCurrencyTypeException();
        }
        
        public override Currency Exchange(USDCurrency from, string to)
        {
            if (to == "USD")
            {
                return new USDCurrency(from.Value);
            } 
            
            if (to == "EUR")
            {
                return new EURCurrency(from.Value * 0.91);
            } 
            
            if (to == "CLP")
            {
                return new CLPCurrency(from.Value * 791.16);
            }

            throw new InvalidCurrencyTypeException();
        }
        
        public override Currency Exchange(EURCurrency from, string to)
        {
            if (to == "USD")
            {
                return new USDCurrency(from.Value / 0.91);
            } 
            
            if (to == "EUR")
            {
                return new EURCurrency(from.Value);
            } 
            
            if (to == "CLP")
            {
                return new CLPCurrency(from.Value * 871.03);
            }

            throw new InvalidCurrencyTypeException();
        }
        
    }
}