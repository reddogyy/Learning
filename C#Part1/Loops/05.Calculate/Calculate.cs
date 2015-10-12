/*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.
 */

using System;
class Calculate
{
    static void Main()
    {
        int n=0;
        int x=0;
        Console.Write("Please enter a value for n : ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Please enter a value for x : ");
        x = int.Parse(Console.ReadLine());

        decimal xAtPowerN = 1.00m;
        decimal factorial = 1.00m;
        decimal sum = 1.00m;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            xAtPowerN *= x;
            sum += (factorial / xAtPowerN);
        }
        Console.WriteLine("The sum is : {0}", sum);
    }
}
