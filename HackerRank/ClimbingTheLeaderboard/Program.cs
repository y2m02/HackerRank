using System;
using System.Collections.Generic;
using System.Linq;

namespace ClimbingTheLeaderboard
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 6, 4, 2, 1
            var result = ClimbingLeaderboard(
                ranked: new() { 100, 100, 50, 40, 40, 20, 10 },
                player: new() { 5, 25, 50, 120 }
            );

            var a = "100 90 90 80 75 60";
            var b = "50 65 77 90 102";

            var result2 = ClimbingLeaderboard(
                ranked: a.Split(' ').Select(x => Convert.ToInt32(x)).ToList(),
                player: b.Split(' ').Select(x => Convert.ToInt32(x)).ToList()
            );

            Console.ReadKey();
        }

        public static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player)
        {
            var positions = new List<int>();

            var distinct = ranked.Distinct().ToList();

            foreach (var play in player)
            {
                var position = 0;

                for (var i = distinct.Count - 1; i >= 0; i--)
                {
                    var ranking = distinct[i];

                    if (play < ranking) { break; }

                    position = i;
                }

                positions.Add(position + 1);
            }

            return positions;
        }

        public static List<int> ClimbingLeaderboardWithLinq(List<int> ranked, List<int> player)
        {
            var positions = new List<int>();

            foreach (var play in player)
            {
                var counter = 0;

                ranked.Add(play);

                var rankings = ranked
                    .OrderByDescending(r => r)
                    .GroupBy(r => r)
                    .ToDictionary(x => x.Key, _ => ++counter);

                positions.Add(rankings[play]);
            }

            return positions;
        }
    }
}
