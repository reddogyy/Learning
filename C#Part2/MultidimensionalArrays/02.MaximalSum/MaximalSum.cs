/*Problem 2. Maximal sum

Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
 */

using System;
class MaximalSum
{
    static void Main()
    {
        Console.Write("Please enter a value N for the Matrix : ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Please enter a value M for the Matrix : ");
        int numberM = int.Parse(Console.ReadLine());
        Console.Write("Please enter a height of the platform : ");
        int heigth = int.Parse(Console.ReadLine());
        Console.Write("Please enter a width of the platform : ");
        int width = int.Parse(Console.ReadLine()); 
        int[,] matrix = new int[numberN, numberM];
        string inputNumber;
        for (int row = 0; row < numberN; row++)
        {
            for (int column = 0; column < numberM; column++)
            {
                Console.Write("matrix[{0},{1}] = ", row, column);
                inputNumber = Console.ReadLine();
                matrix[row, column] = int.Parse(inputNumber);
            }
        }
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) -heigth+ 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) -width + 1; col++)
            {
                int sum = 0;
                for (int platformRow = row; platformRow < row + heigth; platformRow++)
                {
                    for (int platformCol = col; platformCol < col + width; platformCol++)
                    {
                        sum += matrix[platformRow, platformCol];
                    }
                }

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine("Maximal sum platform is : ");
        for (int platformRow = bestRow; platformRow < bestRow + heigth; platformRow++)
        {
            for (int platformCol = bestCol; platformCol < bestCol + width; platformCol++)
            {
                Console.Write("{0} ",matrix[platformRow, platformCol]);
            }
            Console.WriteLine();
        }

    }
}

