/*
 * Problem 9. Matrix of Numbers

Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.
 */

using System;
class MatrixOfNumbers
{
    static void Main()
    {

        int n;
        Console.Write("Please enter a value for n : ");
        n = int.Parse(Console.ReadLine());
        if (n > 1 && n < 20)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int coll = 0; coll < n; coll++)
                {
                    Console.Write("{0}", coll + row);
                }
                Console.WriteLine();

            }
        }
        else
        {
            Console.Write("the entered integer is bigger than 20 or smaller than 1 ");
        }
    }
}

