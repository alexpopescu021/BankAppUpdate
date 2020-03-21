 using System;

namespace BankApp
{
    internal class MasterCard : CardTypes
    {
       
        public override void Plata()
        {
            Console.WriteLine("Payment accepted with MasterCard");
        }
    }
}