using System;
using System.Collections.Generic;

namespace BankApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("1. Plata cu cardul ***** 2. Plata prin transfer bancar ***** 3. Crypto");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice) // Incalca principiul open/close
            {
                case 1:
                    {
                        Console.WriteLine("Enter first 4 digits:\n");
                        int serial = Convert.ToInt32(Console.ReadLine());
 
                        CardTypes card = new CardTypes { Serial = serial };
                        card.AddCard(new MasterCard() { Serial = 1234 });
                        card.AddCard(new Visa() { Serial = 2109, });
                        card.SelectCardForTransfer(Convert.ToInt32(serial));
                      
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter IBAN:\n");
                        long _Iban = Convert.ToInt64(Console.ReadLine());
                        Bank bank = new Bank { IBAN = _Iban };
                        bank.AddBank(new BCR() { IBAN = 9876 });
                        bank.SelectBankForTransfer(Convert.ToInt64(_Iban));
                        break;
                    }

                case 3:
                    {
                        CryptoTypes crypto = new CryptoTypes();
                        Console.WriteLine("1. BitCoin");
                        int id = Convert.ToInt32(Console.ReadLine());
                        crypto.AddCrypto(new Bitcoin() { ID = 1 });
                        crypto.SelectCryptoForTransfer(id);
                       
                        break;
                    }
            }
        }
    }
}