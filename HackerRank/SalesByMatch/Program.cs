using System;
using System.Linq;

namespace SalesByMatch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = GetPairsTotal(
                9,
                new[]
                {
                    10, 20, 20, 10, 10, 30, 50, 10, 20,
                }
            );

            Console.ReadKey();
        }

        private static int GetPairsTotal(int n, int[] ar)
        {
            var container = new int[ar.Max() + 1];

            foreach (var number in ar)
            {
                container[number]++;
            }

            return container.Sum(w => w / 2);
        }
    }
}