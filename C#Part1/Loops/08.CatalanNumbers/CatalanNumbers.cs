/*Problem 8. Catalan Numbers

In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
 */

using System;
class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Please enter a number : ");
        long num = long.Parse(Console.ReadLine());
        if (num > 0 && num < 31)
        {
            long numerator = 1;
            long denominator = 1;
            long result = 1;

            for (int k = 2; k <= num; k++)
            {
                numerator *= (num + k);
                if (numerator % k == 0)
                {
                    numerator /= k;
                }
                else
                {
                    denominator *= k;
                }
            }
            result = numerator / denominator;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}
