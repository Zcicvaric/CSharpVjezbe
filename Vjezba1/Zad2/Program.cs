using System;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            long maxLong = long.MaxValue;
            int someInt;

            try
            {
                checked
                {
                    someInt = (int)maxLong;
                }
                
            }
            catch (System.OverflowException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
