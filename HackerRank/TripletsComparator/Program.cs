using System;
using System.Collections.Generic;

namespace TripletsComparator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = CompareTriplets(
                new List<int>
                {
                    1, 2, 3,
                },
                new List<int>
                {
                    3, 2, 1,
                }
            );

            Console.ReadKey();
        }

        private static List<int> CompareTriplets(List<int> aliceRating, List<int> bobRating)
        {
            var aliceAwardedPoints = 0;
            var bobAwardedPoints = 0;

            for (var i = 0; i < 3; i++)
            {
                var alicePoints = aliceRating[i];

                var bobPoints = bobRating[i];

                if (alicePoints == bobPoints)
                {
                    continue;
                }

                if (alicePoints > bobPoints)
                {
                    aliceAwardedPoints++;
                }
                else
                {
                    bobAwardedPoints++;
                }
            }

            return new List<int>
            {
                aliceAwardedPoints, bobAwardedPoints,
            };
        }
    }
}