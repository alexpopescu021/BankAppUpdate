using System;
using System.Collections.Generic;

namespace BankApp
{
    internal class CryptoTypes
    {
        
        public int ID;
        private readonly List<CryptoTypes> CryptoList = new List<CryptoTypes>();
        
        public void SelectCryptoForTransfer(int id)
        {
            foreach (var crypto in CryptoList)
            {
                if (crypto.ID == id)
                {
                    crypto.Plata();
                    return;
                }
            }
            Console.WriteLine("Invalid");
        }

        public void AddCrypto(CryptoTypes coin)
        {
            CryptoList.Add(coin);

        }
        public virtual void Plata() { }
        // needs new function for different crypto
    }
}