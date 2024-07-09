using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Solutions
    {
        // Diagonal Difference Solution
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int n = arr.Count;
            int diagonalA = 0;
            int diagonalB = 0;

            for (int i = 0; i < n; i++)
            {
                diagonalA += arr[i][i];
                diagonalB += arr[i][n - i - 1];
            }

            return Math.Abs(diagonalA - diagonalB);
        }
    }
}
