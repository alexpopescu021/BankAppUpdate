using System;

namespace BankApp
{
    internal class Providers
    {
        public virtual void Show()
        {
        }

        public virtual void Plata()
        {
            Console.WriteLine("Payment accepted");
        }
    }
}