using System;

namespace Staircase
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Staircase(6);

            Console.ReadKey();

            Console.WriteLine("Hello World!");
        }

        private static void Staircase(int n)
        {
            for (int symbolsCounter = 1, whiteSpacesCounter = n;
                 symbolsCounter <= n;
                 symbolsCounter++, whiteSpacesCounter--
            )
            {
                for (var counter = 1; counter <= whiteSpacesCounter; counter++)
                {
                    Console.Write(" ");
                }

                for (var counter = 1; counter <= symbolsCounter; counter++)
                {
                    Console.Write("#");
                }

                if (symbolsCounter == n)
                {
                    return;
                }

                Console.WriteLine();
            }
        }
    }
}