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
            public string vrstaRacuna;
        }

        static void Main(string[] args)
        {
            string[] vrsteRacuna = { "Stednja", "Tekuci racun", "Ziro racun" };

            BankAccount[] bankAccounts = new BankAccount[5];
            int numberOfAccounts = 0;

            while(true)
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
                    Console.WriteLine("(0 za stednju, 1 za tekuci racun i 2 za ziro racun)");
                    int accountTypeNumber;
                    string accountTypeInput = Console.ReadLine();


                    int.TryParse(accountTypeInput, out accountTypeNumber);
                    bankAccounts[numberOfAccounts].vrstaRacuna = vrsteRacuna[accountTypeNumber];

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
    }
}
