using System;
using System.Collections.Generic;

namespace DiagonalDifference
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = GetDiagonalDifference(
                new List<List<int>>
                {
                    new List<int>
                    {
                        1, 2, 3,
                    },
                    new List<int>
                    {
                        4, 5, 6,
                    },
                    new List<int>
                    {
                        7, 8, 9,
                    },
                }
            );

            Console.ReadKey();
        }

        private static int GetDiagonalDifference(List<List<int>> matrix)
        {
            var mainDiagonal = 0;
            var secondDiagonal = 0;

            var length = matrix.Count;

            for (var row = 0; row < length; row++)
            {
                for (var column = 0; column < length; column++)
                {
                    var value = matrix[row][column];

                    if (row == column)
                    {
                        mainDiagonal += value;
                    }

                    if (row + column == length - 1)
                    {
                        secondDiagonal += value;
                    }
                }
            }

            return Math.Abs(mainDiagonal - secondDiagonal);
        }
    }
}