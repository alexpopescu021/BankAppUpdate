using System;

namespace BankApp
{
    internal class Bank : Providers
    {
        public string Name { get; set; }
        public long IBAN { get; set; }

        public void Update()
        {
        }
        override public void Plata()
        {
            Console.WriteLine("Payment accepted with bank");
        }

        public bool checkIBAN()
        {
            return false;
        }
    }
}