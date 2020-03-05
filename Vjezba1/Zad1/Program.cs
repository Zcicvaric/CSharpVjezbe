using System;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number:");
            string firstNumberInput = Console.ReadLine();
            int firstNumberInt, secondNumberInt;

            int.TryParse(firstNumberInput, out firstNumberInt);

            Console.WriteLine("Second number:");
            string secondNumberInput = Console.ReadLine();
            int.TryParse(secondNumberInput, out secondNumberInt);

             
            if (firstNumberInt != 0 && secondNumberInt != 0) {
                int resultInt = firstNumberInt / secondNumberInt;
                Console.WriteLine("Result (Currency): " + resultInt.ToString("C"));
                Console.WriteLine("Result (Integer): " + resultInt);
                Console.WriteLine("Result (Scientific): " + string.Format("{0:E2}", resultInt));
                Console.WriteLine("Result (Float): " + resultInt.ToString("F"));
                Console.WriteLine("Result (General): " + resultInt.ToString("G"));
                Console.WriteLine("Result (Number): " + resultInt.ToString("N"));
                Console.WriteLine("Result (Hexadecimal): " + resultInt.ToString("X"));
            }

        }
    }
}
