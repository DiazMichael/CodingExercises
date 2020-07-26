using System;

namespace SumOfDiagonalsInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            var matrixDimension = Convert.ToInt32(arr[0][0]);
            var firstDiagonal = new int[matrixDimension];
            var secondDiagonal = new int[matrixDimension];

            for (var i = 0; i < matrixDimension; i++)
            {
                firstDiagonal[i] = arr[i + 1][i];
                secondDiagonal[i] = arr[i + 1][matrixDimension - 1 - i];
            }
            return Math.Abs(firstDiagonal.Sum() - secondDiagonal.Sum());
        }
    }
}
