using System;
using System.Linq;

namespace AngryProfessor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = ClassIsCancelled(
                3,
                new[]
                {
                    -1, -3, 4, 2,
                }
            );

            Console.WriteLine("Hello World!");
        }

        private static string ClassIsCancelled(int cancellationThreshold, int[] studentsArrivalTimes)
        {
            // With Linq
            return studentsArrivalTimes.Count(arrivalTime => arrivalTime <= 0) >= cancellationThreshold ? "NO" : "YES";

            // Without Linq
            //var studentsOnTime = 0;

            //foreach (var arrivalTime in studentsArrivalTimes)
            //{
            //    studentsOnTime += arrivalTime <= 0 ? 1 : 0;
            //}

            //return studentsOnTime >= cancellationThreshold ? "NO" : "YES";
        }
    }
}