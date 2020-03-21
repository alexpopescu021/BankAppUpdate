using System;

namespace BankApp
{
    internal class BCR : Bank
    {
        public decimal conversionRate;
        public decimal ConvertToBitcoin(decimal payment)
        {

            return payment *this.conversionRate;

        }
        override public void Plata()
        {
            Console.WriteLine("Payment accepted with BCR");
        }
    }
}