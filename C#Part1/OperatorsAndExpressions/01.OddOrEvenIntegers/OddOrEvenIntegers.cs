/*Problem 1. Odd or Even Integers

Write an expression that checks if given integer is odd or even. */

using System;


class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Odd or Even Integers.\n");
        int inputNumber;
        Console.WriteLine("Please enter a number:");
        inputNumber = Convert.ToInt32(Console.ReadLine());
        if ((inputNumber % 2) == 0)
        {
            Console.WriteLine("The entered number {0} is Even", inputNumber);
        }
        else
        {
            Console.WriteLine("The entered number {0} is Odd", inputNumber);
        }

    }
}

