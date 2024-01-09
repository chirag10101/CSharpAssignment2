using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class Program4
    {
        public static void SumOfColumns()
        {
            int[,] mat = { { 1, 2, 3  }, { 3, 4, 5  }, { 6, 7, 8  } };
            int m= mat.GetLength(1);
            int n= mat.GetLength(0);
            int sum;
            Console.WriteLine("Column wise sum of 2d array :- ");
            for(int i=0; i<m; i++)
            {
                sum = 0;
                for(int j=0; j<n; j++)
                {
                    sum += mat[j,i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
