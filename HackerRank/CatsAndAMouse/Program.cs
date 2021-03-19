using System;

namespace CatsAndAMouse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = GetTheClosestCat(2, 5, 4);
            Console.ReadKey();
        }

        private static string GetTheClosestCat(int x, int y, int z)
        {
            var catADistance = Math.Abs(z - x);
            var catBDistance = Math.Abs(z - y);

            return catADistance == catBDistance
                ? "Mouse C"
                : catADistance < catBDistance
                    ? "Cat A"
                    : "Cat B";
        }
    }
}