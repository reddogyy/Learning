/*Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
 */

using System;
class SumOf5Numbers
{
    static void Main()
    {
        string numbers;
        Console.Write("Plese enter 5 numbers on a single line, and separeted by space:");
        numbers = Console.ReadLine();
        string[] stringsArray = numbers.Split(' ');
        double sum= 0D;
        for (int i = 0; i < stringsArray.Length; i++)
        {
            sum += double.Parse(stringsArray[i]);
        }
        Console.WriteLine("The sum is {0}", sum);

    }
}

