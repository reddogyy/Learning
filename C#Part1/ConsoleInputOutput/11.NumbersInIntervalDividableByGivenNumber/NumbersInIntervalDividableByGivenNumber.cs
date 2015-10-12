/*Problem 11.* Numbers in Interval Dividable by Given Number

Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
 */

using System;
class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        int firstInteger;
        Console.Write("Please enter first number :");
        firstInteger = int.Parse(Console.ReadLine());
        int secondInteger;
        Console.Write("Please enter second number : ");
        secondInteger = int.Parse(Console.ReadLine());
        bool isDivideBy5 = false;
        int count = 0;
        for (int i = firstInteger; i <= secondInteger; i++)
        {
            if ((i % 5) == 0)
            {
                isDivideBy5 = true;
                count++;
                Console.WriteLine("Number that is divided by 5 is :{0}", i);
            }
            else
            {
                isDivideBy5 = false;
            }
        }
        if (isDivideBy5 == true)
        {
            Console.WriteLine("Currently we have {0} numbers that are divided by 5", count);
        }
        else
        {
            Console.WriteLine("there is no number that can be divided by 5 with reminder 0!");
        }
    }
}

