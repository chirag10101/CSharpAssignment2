using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class Program2
    {
        public static int SumOfMatrix()
        {
            int[,] mat = { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } };
            Console.WriteLine("Matrix : ");
            int sum = 0;
            for(int i = 0; i <3; i++)
            {
                for(int j = 0; j <3; j++)
                {
                    Console.Write(mat[i, j]+" ");
                    sum += mat[i, j];
                }
                Console.WriteLine();
            }
            return sum;
        }
    }
}
