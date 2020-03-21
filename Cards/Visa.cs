using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Visa : CardTypes
    {
        public long ID { get; set; }

       
        public override void Plata()
        {
            Console.WriteLine("Payment accepted with Visa");
        }
    }
}
