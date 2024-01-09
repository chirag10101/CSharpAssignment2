using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class Program5
    {
        public static void SumOfRows()
        {
            Console.WriteLine("Sum of rows of 2d array");
            int[,] mat = { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } };
            int m = mat.GetLength(1);
            int n = mat.GetLength(0);
            int sum;
            for (int i = 0; i < n; i++)
            {
                sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += mat[i, j];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
