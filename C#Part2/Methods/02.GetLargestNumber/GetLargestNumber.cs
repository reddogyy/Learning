/*Problem 2. Get largest number

Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
 */

using System;
class GetLargestNumber
    {
    static int GetMax(int firstNumber, int secondNumber)
    {
        int maximumNumber;
        if (firstNumber > secondNumber)
        {
            maximumNumber = firstNumber;
        }
        else
        {
            maximumNumber = secondNumber;
        }

        return maximumNumber;

    }
        static void Main()
        {
            Console.Write("Please enter a number :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter a number :");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Please enter a number :");
            int c = int.Parse(Console.ReadLine());
            int tempMax = GetMax(a, b);
            Console.WriteLine("The maximal number is {0}", GetMax(c, tempMax));

        }
    }
