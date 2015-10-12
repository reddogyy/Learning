/*Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.
 */

using System;
class SumOf3Numbers
{
    static void Main()
    {
        int firstNumber;
        int secondNumber;
        int thirdNumber;
        Console.Write("Please enter your first number :");
        firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter your second number :");
        secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter your third number : ");
        thirdNumber = int.Parse(Console.ReadLine());
        int result = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum of {0} ,{1} and {2} is : {3}", firstNumber, secondNumber, thirdNumber,result);

    }
}
