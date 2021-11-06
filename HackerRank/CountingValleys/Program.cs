using System;
using System.Linq;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = CountingValleys(8, "UDDDUDUU");

            Console.ReadKey();
        }

        public static int CountingValleys(int steps, string path)
        {
            var max = 0;
            var counter = 0;
            var backAtTheSeaLevel=true;

            foreach (var @char in path)
            {
                counter += @char == 'D' ? -1 : 1;

                if (counter == 0)
                {
                    backAtTheSeaLevel = true;
                }

                if (backAtTheSeaLevel && counter < 0)
                {
                    max++;
                    backAtTheSeaLevel = false;
                }
            }

            return max;
        }
    }
}
