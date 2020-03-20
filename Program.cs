using System;

namespace BankApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("1. Plata cu cardul ***** 2. Plata prin transfer bancar ***** 3. Crypto");
            int choice = Convert.ToInt32(Console.ReadLine());
            // providers.ForEach(Console.WriteLine);
            switch (choice) // Incalca principiul open/close
            {
                case 1:
                    {
                        Console.WriteLine("Enter Serial:\n");
                        long serial = Convert.ToInt64(Console.ReadLine());
                        CardTypes card = new CardTypes { Serial = serial };
                        card.Update();

                        bool da = card.checkID();

                        if (da)
                        {
                            card.Plata();
                        }

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter IBAN:\n");
                        long _Iban = Convert.ToInt64(Console.ReadLine());
                        Bank bank = new Bank { IBAN = _Iban };
                        if (bank.checkIBAN())
                            bank.Plata();
                        // not implemented

                        break;
                    }

                case 3:
                    {
                        CryptoTypes crypto = new CryptoTypes();
                        Console.WriteLine("Currently only abe to pay in Bitcoin\nChoose sum:\n");
                        decimal payment = Convert.ToInt32(Console.ReadLine());
                        decimal convertedPayment = crypto.ConvertToBitcoin(payment);
                        crypto.Plata(/*convertedPayment*/);
                        break;
                    }
            }
        }
    }
}