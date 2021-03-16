using System;
using System.Collections.Generic;
using System.Linq;

namespace BetweenTwoSets
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = GetTotalFactors(
                new List<int>
                {
                    2, 4,
                },
                new List<int>
                {
                    16, 32, 96,
                }
            );

            Console.ReadKey();
        }

        private static int GetTotalFactors(List<int> a, List<int> b)
        {
            return Enumerable
                .Range(a.Max(), b.Min())
                .Count(
                    w => a.TrueForAll(x => w % x == 0) &&
                         b.TrueForAll(x => x % w == 0)
                );
        }
    }
}