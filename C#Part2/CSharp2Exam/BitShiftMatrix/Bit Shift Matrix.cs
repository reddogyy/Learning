using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShiftMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            long[,] matrix = new long[rows, cols];
            string code = Console.ReadLine();
            int coeff = Math.Max(rows, cols);
            string[] codes = code.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] codesRow = new int[codes.Length];
            int[] codesCol = new int[codes.Length];
            for (int i = 0; i < n; i++)
            {
                codesRow[i] = int.Parse(codes[i]) / coeff;
                codesCol[i] = int.Parse(codes[i]) % coeff;
            }


            matrix[rows - 1, 0] = 1;
            matrix[rows - 1, 1] = 2;
            for (int i = 1; i < cols; i++)
            {
                matrix[rows - 1, i] = matrix[rows - 1, i - 1] * 2;
            }

            for (int i = matrix.GetLength(0) - 2; i >= 0; i--)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix[i + 1, j] * 2;
                }
            }
            int row = rows - 1;
            int col = 0;
            long sum = 0;
            int colomns = 0;
            for (int i = 0; i < n; i++)
            {
               
                for ( int j = col; j < codesCol[i] + 1; j++)
                {
                    long temp = matrix[row, j];
                    sum = sum + temp;
                     colomns = j;
                     matrix[row, j] = 0;
                     
                }
      //          row--;
                    for (int f = row; f >= codesRow[i]; f--)
                    {
                        long temp = matrix[f, colomns];
                        sum = sum + temp;
                        matrix[f, colomns] = 0;
                    }
                
                col = codesCol[i];
                row = codesRow[i];
                col++;
            }
            Console.WriteLine(sum);
        }
    }
}
