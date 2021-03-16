using System;

namespace NumberLineJumps
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // d * v1 + x1 - d * v2 + x2 = 0
            var a = CanBeOnTheSameLocation(4523, 8092, 9419, 8076);

            Console.WriteLine("Hello World!");
        }

        private static string CanBeOnTheSameLocation(int x1, int v1, int x2, int v2)
        {
            return (x2 - x1) * (v2 - v1) < 0 && (x2 - x1) % (v2 - v1) == 0 ? "YES" : "NO";
        }
    }
}