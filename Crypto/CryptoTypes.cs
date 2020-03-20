using System;

namespace BankApp
{
    internal class CryptoTypes : Providers
    {
        override public void Plata(/*convertedPayment*/)
        {
            Console.WriteLine("Payment accepted");
        }

        public decimal ConvertToBitcoin(decimal payment)
        {
            Bitcoin coin = new Bitcoin();
            return payment * coin.conversionRate;
        }

        // needs new function for different crypto
    }
}