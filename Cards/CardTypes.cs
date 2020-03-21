using System;
using System.Collections.Generic;

namespace BankApp
{
    internal class CardTypes
    {
        public string Name { get; set; }
        public int Serial { get; set; }

        private readonly List<CardTypes> CardsList = new List<CardTypes>();
        public void SelectCardForTransfer(int id)
        {
            foreach (var card in CardsList)
            {
                if (card.Serial == id)
                {
                    card.Plata();
                    return;
                }
            }
            Console.WriteLine("Invalid");
        }

        public void AddCard(CardTypes card)
        {
            CardsList.Add(card);
           
        }

        public virtual void Plata() { }

    }
}