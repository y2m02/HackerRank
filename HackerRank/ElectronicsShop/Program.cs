using System;
using System.Linq;

namespace ElectronicsShop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = GetMoneySpent(
                new[]
                {
                    3, 1,
                },
                new[]
                {
                    5, 2, 8,
                },
                10
            );

            Console.ReadKey();
        }

        private static int GetMoneySpent(int[] keyboards, int[] drives, int b)
        {
            var totalMoneySpent = 0;

            foreach (var keyboard in keyboards)
            {
                foreach (var drive in drives)
                {
                    var moneySpent = keyboard + drive;

                    if (moneySpent <= b && totalMoneySpent < moneySpent)
                    {
                        totalMoneySpent = moneySpent;
                    }
                }
            }


            return totalMoneySpent > 0 ? totalMoneySpent : -1;
        }
    }
}