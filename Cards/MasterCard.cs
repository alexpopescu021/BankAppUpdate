using System;

namespace BankApp
{
    internal class MasterCard : CardTypes
    {
        public long ID { get; set; }

        public override void Show()
        {
            Console.WriteLine("MasterCard");
        }
    }
}