using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Inputs
    {
        // Diagonal Difference Input
        public static void DiagonalDifferenceInput()
        {
            List<List<int>> arr = new List<List<int>>
            {
                new List<int> {11, 2, 4},
                new List<int> {4, 5, 6},
                new List<int> {10, 8, -12}
            };

            int result = Solutions.DiagonalDifference(arr);
            Console.WriteLine(result);
        }

    }
}
