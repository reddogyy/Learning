/*Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
 */

using System;

class SequenceNMatrix
{


    static void Main()
    {
        Console.Write("Please enter a value N for the Matrix : ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Please enter a value M for the Matrix : ");
        int numberM = int.Parse(Console.ReadLine());
        string[,] matrix = new string[numberN, numberM];
        int counter = 0;
        int bestRow = 0;
        int bestCol = 0;
        int bestDiagonal = 0;
        for (int row = 0; row < numberN; row++)
        {
            for (int column = 0; column < numberM; column++)
            {
                Console.Write("matrix[{0},{1}] = ", row, column);
                matrix[row, column] = Console.ReadLine();
            }
        }
        string bestString = null;
        string currString = matrix[0, 0];
        //row
       for (int row = 0; row < numberN; row++)
       {
            for (int col = 0; col < numberM; col++)
            {
               
                    if (matrix[row, col] == currString)
                    {
                        counter++;

                        if (bestRow < counter)
                        {
                            bestRow = counter;
                            currString = matrix[row, col];
                            bestString = currString;
                        }
                    }
                    else
                    {
                        counter = 1;
                        currString = matrix[row, col];
                    }
                
            }
        }
        //col
       for (int row = 0; row < numberN; row++)
       {
           for (int col = 0; col < numberM; col++)
           {

               if (matrix[col, row] == currString)
               {
                   counter++;

                   if (bestRow < counter)
                   {
                       bestCol = counter;
                       currString = matrix[col, row];
                       bestString = currString;
                   }
               }
               else
               {
                   counter = 1;
                   currString = matrix[col, row];
               }

           }
       }
        //Diagonal
       for (int row = 0; row < numberN-1; row++)
       {
           for (int col = 0; col < numberM-1; col++)
           {

               if (matrix[row, col] == matrix[row+1, col+1])
               {
                   counter++;

                   if (bestDiagonal < counter)
                   {
                       bestDiagonal = counter;
                       currString = matrix[row, col];
                       bestString = currString;
                   }
               }
               else
               {
                   counter = 1;
                   currString = matrix[row, col];
               }

           }
       }
       if (bestRow > bestCol)
       {
           if (bestRow > bestDiagonal)
           {
               for (int j = 0; j < bestRow; j++)
               {
                   Console.Write("{0}, ", bestString);
               }
               Console.WriteLine();
           }
           else
           {
               for (int j = 0; j < bestDiagonal; j++)
               {
                   Console.Write("{0}, ", bestString);
               }
               Console.WriteLine();
           }
       }
       else
       {
           if (bestCol > bestDiagonal)
           {
               for (int j = 0; j < bestCol; j++)
               {
                   Console.Write("{0}, ", bestString);
               }
               Console.WriteLine();
           }
           else
           {
               for (int j = 0; j < bestDiagonal; j++)
               {
                   Console.Write("{0}, ", bestString);
               }
               Console.WriteLine();
           }
       }

    }
}

