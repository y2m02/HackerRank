using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCakeCandles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = CountTallestCandlesTotal(
                new List<int>
                {
                    4, 4, 1, 3,
                }
            );

            Console.WriteLine("Hello World!");
        }

        private static int CountTallestCandlesTotal(List<int> candles)
        {
            var tallestCandle = candles.Max();

            return candles.Count(x => x == tallestCandle);
        }
    }
}