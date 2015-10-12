/*Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:
Example for n=4:

a)	
1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16
 * b)
1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13
 * c)
7	11	14	16
4	8	12	15
2	5	9	13
1	3	6	10
 * d)*
1	12	11	10
2	13	16	9
3	14	15	8
4	5	6	7
 */
using System;
class Program
{
    static void Main()
    {
        Console.Write("Please enter a value N for the Matrix : ");
        int numberN = int.Parse(Console.ReadLine());
        int[,] matrix = new int[numberN,numberN];
        Console.WriteLine("Matrix type A:");
        int value = 1;
        //matrix A;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {

                matrix[col, row] = value++;
            }

        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(" {0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
        //matrix B;
        value = 1;
        Console.WriteLine("Matrix type B:");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[col, row] = value++;
                }
            }
            else
            {
                for (int col = matrix.GetLength(0) - 1; col >= 0; col--)
                {
                    matrix[col, row] = value++;
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(" {0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
        value = 1;
        //matrix C;
        Console.WriteLine("Matrix type C:");
        int rows = 0;
        int cols = 0;
        for (int i = numberN - 1; i >= 0; i--)
        {
            rows = i;
            cols = 0;
            while (rows < numberN && cols < numberN)
            {
                matrix[rows++, cols++] = value++;
            }
        }

        for (int j = 1; j < numberN; j++)
        {
            rows = j;
            cols = 0;
            while (rows < numberN && cols < numberN)
            {
                matrix[cols++, rows++] = value++;
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(" {0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
        //matrix D
        int numberToAdd = 1;
        int globalCounter = numberN;
        int tempValue = -numberN;
        int sum = -1;
        Console.WriteLine("Matrix D:");
        do
        {
            tempValue = -1 * tempValue / numberN;
            for (int i = 0; i < globalCounter; i++)
            {
                sum += tempValue;
                matrix[sum / numberN, sum % numberN] = numberToAdd;
                numberToAdd++;
            }
            tempValue *= numberN;
            globalCounter--;
            for (int i = 0; i < globalCounter; i++)
            {
                sum += tempValue;
                matrix[sum / numberN, sum % numberN] = numberToAdd;
                numberToAdd++;
            }
        } while (globalCounter > 0);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(" {0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }


    }
}
