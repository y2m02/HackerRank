using System;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var a = GetTheSmallestBirdId(
                new List<int>
                {
                    1,
                    1,
                    1,
                    4,
                    4,
                    4,
                    4,
                    4,
                    5,
                    5,
                    5,
                    5,
                    5,
                    5,
                    3,
                    3,
                    3,
                    3,
                    3,
                    3,
                }
            );

            Console.WriteLine("Hello World!");
        }

        private static int GetTheSmallestBirdId(List<int> birdIds)
        {
            return birdIds
                .GroupBy(id => id)
                .Select(group => (id: group.Key, repetitions: group.Count()))
                .GroupBy(bird => bird.repetitions)
                .OrderByDescending(group => group.Key)
                .First()
                .OrderBy(bird => bird.id)
                .First()
                .id;
        }
    }
}