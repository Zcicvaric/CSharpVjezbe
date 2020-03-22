using System;
using System.Globalization;

namespace Zad3
{
    class Program
    {
        public struct BankAccount
        {
            public string brojRacuna;
            public float iznosNaRacunu;
            public VrsteRacuna vrstaRacuna;
        }

       

        static void Main(string[] args)
        {
            BankAccount[] bankAccounts = new BankAccount[5];
            int numberOfAccounts = 0;
            

            while (true)
            {
                Console.WriteLine("Upisite 1 za unos novog racuna, 2 za ispis svih racuna i Exit za kraj rada");
                string userInput = Console.ReadLine();

                if (userInput.Equals("1"))
                {
                    Console.WriteLine("Unesite broj racuna:");
                    bankAccounts[numberOfAccounts].brojRacuna = Console.ReadLine();

                    Console.WriteLine("Unesite iznos na racunu:");
                    string amountInput = Console.ReadLine();
                    bankAccounts[numberOfAccounts].iznosNaRacunu = float.Parse(amountInput, CultureInfo.InvariantCulture);

                    Console.WriteLine("Unesite vrstu racuna:");
                    string accountTypeInput = Console.ReadLine();

                    if (accountTypeInput.Equals("Stednja"))
                        bankAccounts[numberOfAccounts].vrstaRacuna = VrsteRacuna.Stednja;
                    else if (accountTypeInput.Equals("Tekuci"))
                        bankAccounts[numberOfAccounts].vrstaRacuna = VrsteRacuna.Tekuci;
                    else if (accountTypeInput.Equals("Ziro"))
                        bankAccounts[numberOfAccounts].vrstaRacuna = VrsteRacuna.Ziro;
                    numberOfAccounts++;
                }

                else if (userInput.Equals("2")) 
                { 
                    foreach(BankAccount bankAccount in bankAccounts)
                    {
                        Console.WriteLine("Broj racuna: " + bankAccount.brojRacuna + " Iznos na racunu: " + bankAccount.iznosNaRacunu + " Vrsta racuna: " + bankAccount.vrstaRacuna);
                    }
                
                }

                else if (userInput.Equals("Exit"))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Neispravan unos!");
                }
        }
            
        }
        public enum VrsteRacuna
        {
            Stednja = 0,
            Tekuci = 1,
            Ziro = 2
        }
    }
}
