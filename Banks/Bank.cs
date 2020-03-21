using System;
using System.Collections.Generic;

namespace BankApp
{
    internal class Bank
    {
        public string Name { get; set; }
        public long IBAN { get; set; }

        public virtual void Plata() { }

        private readonly List<Bank> BanksList = new List<Bank>();
        public void SelectBankForTransfer(long id)
        {
            foreach (var bank in BanksList)
            {
                if (bank.IBAN == id)
                {
                    bank.Plata();
                    return;
                }
            }
            Console.WriteLine("Invalid");
        }

        public void AddBank(Bank bank)
        {
            BanksList.Add(bank);

        }
    }
}