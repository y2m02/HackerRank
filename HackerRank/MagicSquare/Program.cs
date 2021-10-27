using System;
using System.Collections.Generic;

namespace MagicSquare
{
    public class Program
    {
        private static string CalculatePrefix(string[] words)
        {
            var first = words[0];
            var prefix = string.Empty;

            for (var i = 1; i <= first.Length; i++)
            {
                var sub = first.Substring(0, i);
                var a = true;

                for (var x = 1; x < words.Length; x++)
                {
                    if (!words[x].StartsWith(sub))
                    {
                        a = false;
                        break;
                    }
                }

                //if (words.Skip(1).Any(w => !w.StartsWith(sub)))
                //{
                //    break;
                //}
                if (a)
                {
                    prefix = sub;
                }
            }

            return prefix;
        }

        public static void Main(string[] args)
        {
            var now = DateTime.Now;
            //var movements = CalculateMovements(new List<List<int>>
            //{
            //    new() { 4, 8, 2 },
            //    new() { 4, 5, 7 },
            //    new() { 6, 1, 6 }
            //});

            var movements = CalculateAndPrintMovements(new List<List<int>>
            {
                new() { 4, 9, 2 },
                new() { 3, 5, 7 },
                new() { 8, 1, 5 }
            });
            var time = (DateTime.Now - now).TotalSeconds;

            Console.WriteLine($"Min: {movements}");
            Console.WriteLine();
            Console.WriteLine($"Total seconds: {time}");

            Console.ReadKey();
        }

        private static int CalculateMovements(List<List<int>> square)
        {
            var possibleSquares = new List<List<List<int>>>
            {
                new()
                {
                    new() { 2, 9, 4 },
                    new() { 7, 5, 3 },
                    new() { 6, 1, 8 },
                },
                new()
                {
                    new() { 4, 9, 2 },
                    new() { 3, 5, 7 },
                    new() { 8, 1, 6 },
                },

                new()
                {
                    new() { 6, 1, 8 },
                    new() { 7, 5, 3 },
                    new() { 2, 9, 4 },
                },
                new()
                {
                    new() { 8, 1, 6 },
                    new() { 3, 5, 7 },
                    new() { 4, 9, 2 },
                },


                new()
                {
                    new() { 2, 7, 6 },
                    new() { 9, 5, 1 },
                    new() { 4, 3, 8 },
                },
                new()
                {
                    new() { 6, 7, 2 },
                    new() { 1, 5, 9 },
                    new() { 8, 3, 4 },
                },

                new()
                {
                    new() { 4, 3, 8 },
                    new() { 9, 5, 1 },
                    new() { 2, 7, 6 },
                },
                new()
                {
                    new() { 8, 3, 4 },
                    new() { 1, 5, 9 },
                    new() { 6, 7, 2 },
                },
            };

            var min = 100;

            for (var squareIndex = 0; squareIndex < possibleSquares.Count; squareIndex++)
            {
                var sum = 0;

                for (var row = 0; row < square.Count; row++)
                {
                    for (var column = 0; column < square[row].Count; column++)
                    {
                        sum += Math.Abs(possibleSquares[squareIndex][row][column] - square[row][column]);
                    }
                }

                if (sum is 0 or 1) return sum;

                min = Math.Min(sum, min);
            }

            return min;
        }

        private static int CalculateAndPrintMovements(List<List<int>> square)
        {
            var possibleSquares = new List<List<List<int>>>
            {
                new()
                {
                    new() { 2, 9, 4 },
                    new() { 7, 5, 3 },
                    new() { 6, 1, 8 },
                },
                new()
                {
                    new() { 4, 9, 2 },
                    new() { 3, 5, 7 },
                    new() { 8, 1, 6 },
                },

                new()
                {
                    new() { 6, 1, 8 },
                    new() { 7, 5, 3 },
                    new() { 2, 9, 4 },
                },
                new()
                {
                    new() { 8, 1, 6 },
                    new() { 3, 5, 7 },
                    new() { 4, 9, 2 },
                },


                new()
                {
                    new() { 2, 7, 6 },
                    new() { 9, 5, 1 },
                    new() { 4, 3, 8 },
                },
                new()
                {
                    new() { 6, 7, 2 },
                    new() { 1, 5, 9 },
                    new() { 8, 3, 4 },
                },

                new()
                {
                    new() { 4, 3, 8 },
                    new() { 9, 5, 1 },
                    new() { 2, 7, 6 },
                },
                new()
                {
                    new() { 8, 3, 4 },
                    new() { 1, 5, 9 },
                    new() { 6, 7, 2 },
                },
            };

            var min = 100;

            for (var squareIndex = 0; squareIndex < possibleSquares.Count; squareIndex++)
            {
                var sum = 0;

                for (var row = 0; row < square.Count; row++)
                {
                    for (var column = 0; column < square[row].Count; column++)
                    {
                        var wa = square[row][column];
                        var z = possibleSquares[squareIndex][row][column];

                        var difference = Math.Abs(z - wa);
                        sum += difference;

                        Console.WriteLine($"({row}, {column}) --> |{wa} - {z}| = {difference}");
                    }
                }

                min = Math.Min(sum, min);

                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine();
            }

            return min;
        }
    }
}
