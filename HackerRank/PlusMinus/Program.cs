using System;

namespace PlusMinus
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CalculateRatios(
                new[]
                {
                    1, 1, 0, -1, -1,
                }
            );

            Console.ReadKey();
        }

        private static void CalculateRatios(int[] numbers)
        {
            var totalPositiveNumbers = 0;
            var totalNegativeNumbers = 0;
            var totalZeros = 0;

            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    totalPositiveNumbers++;

                    continue;
                }

                if (number < 0)
                {
                    totalNegativeNumbers++;

                    continue;
                }

                totalZeros++;

                //switch (number)
                //{
                //    case > 0:
                //        totalPositiveNumbers++;

                //        break;

                //    case < 0:
                //        totalNegativeNumbers++;

                //        break;

                //    default:
                //        totalZeros++;

                //        break;
                //}
            }

            Print(numbers.Length, totalPositiveNumbers, totalNegativeNumbers, totalZeros);

            //static void Print(int divisor, params int[] numbers)
            //{
            //    foreach (var number in numbers)
            //    {
            //        Console.WriteLine($"{number / (decimal)divisor:F6}");
            //    }
            //}
        }

        static void Print(int divisor, params int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number / (decimal)divisor:F6}");
            }
        }
    }
}