/*Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.
 */

using System;
class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        double firstNumber;
        Console.Write("Please enter your fisrt number :");
        firstNumber = double.Parse(Console.ReadLine());
        double secondNumber;
        Console.Write("Please enter your second number :");
        secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber;
        Console.Write("Please enter your third number :");
        thirdNumber = double.Parse(Console.ReadLine());
        double bigger=0;
        double large = 0;
        double small = 0;
        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                bigger = firstNumber;
                if (secondNumber > thirdNumber)
                {
                    large = secondNumber;
                    small = thirdNumber;
                }
                else
                {
                    large = thirdNumber;
                    small = secondNumber;
                }
            }
            else
            {
                bigger = thirdNumber;
                large = firstNumber;
                small = secondNumber;
            }
        }
        else
        {
            if(secondNumber>thirdNumber)
            {
                bigger = secondNumber;
                if (firstNumber > thirdNumber)
                {
                    large = firstNumber;
                    small = thirdNumber;
                }
                else
                {
                    large = thirdNumber;
                    small = firstNumber;
                }
            }
            else
            {
                bigger = thirdNumber;
                large = secondNumber;
                small = firstNumber;
            }
        }
        Console.WriteLine("The biggest number is {0}, large {1}, small {2}", bigger, large, small);
 
    }
}