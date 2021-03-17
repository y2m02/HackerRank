using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SubarrayDivision
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = GetChocolateDivisions(
                new List<int>
                {
                    1,
                    2,
                    1,
                    3,
                    2,
                },
                3,
                2
            );

            Console.ReadKey();
        }

        private static int GetChocolateDivisions(List<int> s, int d, int m)
        {
            var counter = 0;

            // With linq
            for (var i = 0; i <= s.Count - m; i++)
            {
                if (s.Skip(i).Take(m).Sum(w => w) == d)
                {
                    counter++;
                }
            }

            // Without linq
            //for (var i = 0; i <= s.Count - m; i++)
            //{
            //    var sum = 0;

            //    for (var j = 0; j < m; j++)
            //    {
            //        sum += s[i + j];
            //    }

            //    if (sum == d)
            //    {
            //        counter++;
            //    }
            //}

            return counter;
        }
    }
}