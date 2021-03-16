using System;

namespace DivisibleSumPairs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = DivisibleSumPairs(
                6,
                3,
                new[]
                {
                    1, 3, 2, 6, 1, 2,
                }
            );

            Console.ReadKey();
        }

        private static int DivisibleSumPairs(int n, int k, int[] ar)
        {
            var counter = 0;

            for (var i = 0; i < n; i++)
            {
                for (var j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }
    }
}