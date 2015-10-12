/*Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
 */

using System;
class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Please enter a numbers with space between them, :");
        string numbers = Console.ReadLine();
        string[] numbersArray = numbers.Split(' ');
        int oddSum = 1;
        int evenSum = 1;
        for (int i = 0; i < numbersArray.Length; i++)
        {
            int number = int.Parse(numbersArray[i]);
            if ((i % 2 == 0) || (i == 0))
            {
                evenSum *= number;
            }
            else
            {
                oddSum *= number;
            }
        }
        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine(evenSum);
            Console.WriteLine(oddSum);
        }


    }
}
