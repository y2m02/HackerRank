using System;
using System.Linq;

namespace MinMaxSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CalculateMinAndMaxSum(
                new long[]
                {
                    140537896, 243908675, 670291834, 923018467, 520718469,
                }
            );

            Console.ReadLine();
        }

        private static void CalculateMinAndMaxSum(long[] numbers)
        {
            var sortedNumbers = numbers.OrderBy(n => n).ToList();

            var minSum = sortedNumbers[0] +
                         sortedNumbers[1] +
                         sortedNumbers[2] +
                         sortedNumbers[3];

            var maxSum = sortedNumbers[1] +
                         sortedNumbers[2] +
                         sortedNumbers[3] +
                         sortedNumbers[4];

            Console.Write($"{minSum} {maxSum}");
        }
    }
}