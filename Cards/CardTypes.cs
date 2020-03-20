using System;
using System.Collections.Generic;

namespace BankApp
{
    internal class CardTypes : Providers
    {
        public string Name { get; set; }
        public long Serial { get; set; }

        private List<long> idOfCards = new List<long>();

        public void Update()    //add Id of cards from external file
        {
            idOfCards.Add(1234);
        }

        public bool checkID()
        {
            long id = Serial / (long)1000000000000;

            foreach (var card in idOfCards)
            {
                if (card == id)
                {
                    return true;
                }
            }
            return false;
        }
        public  void Plata()
        {
            Console.WriteLine("Payment accepted with card");
        }
    }
}