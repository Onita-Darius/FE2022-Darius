using System;

namespace FE2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se dau a si b
            int a = 20;
            int b = 30;

            start(a, b);
        }

        private static void start(int a, int b)
        {
            int count = 0;
            int e = 0;
            int high = 0;
            int t;
            int Coll;
            int longest = 0;
            if (a > b)
            {
                t = a - b;
                Coll = a;
                e = Coll;
            }
            else
            {
                t = b - a;
                Coll = b;
                e = Coll;
            }
        Loop:
            Console.WriteLine($"Starting nr.: {e}");
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

            // Determinati cea mai lunga secventa dintre a si b

            if (longest < count) { longest = count; }

            // Determinati lungimea secvenței

            Console.WriteLine($"The lenght of this collatz sequence is: {count}");

            // Determinați cel mai mare numar din secvență

            Console.WriteLine($"Highest number from this sequence is: {high}");

            // Câte secvențe au ramas de calculat

            Console.WriteLine($"Count Down: {t}");

            /// Quality of life

            Console.WriteLine("---------------------------------------------------");

            // Pregătirea pentu urmatoarea secvență

            high = 0;
            Coll--;
            t--;
            count = 0;
            e = Coll;
            if (a > b)
            {
                if (Coll > b - 1)
                    goto Loop;
            }
            else
            {
                if (Coll > a - 1)
                    goto Loop;
            }
            // Cea mai lunga secventa dintre a si b 
            Console.WriteLine($"Longest sequence is: {longest} ");

        }
    }
}
