using System;

namespace FE2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int e = 27;
            int high = 0;
            while (e > 1)
            {

                if (e % 2 == 0)
                {
                    count++;
                    e = e / 2;
                    Console.Write($"{e} ");
                }

                else
                {
                    e = 3 * e + 1;

                    count++;
                    Console.Write($"{e} ");
                }
                if (high < e)
                {
                    high = e;
                };
            }
            Console.WriteLine();
            Console.WriteLine($"The lenght of the collatz sequence is: {count}");
            Console.WriteLine($"Highest number in the sequence is: {high}");

        }
    }
}
