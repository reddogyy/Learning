/*Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.
 */

using System;
class TheBiggestOf3Numbers
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
        double firstBigger;
        double secondBigger;
        if (firstNumber > secondNumber)
        {
            firstBigger = firstNumber;
        }
        else
        {
            firstBigger = secondNumber;
        }
        if (secondNumber > thirdNumber)
        {
            secondBigger = secondNumber;
        }
        else
        {
            secondBigger = thirdNumber;
        }
        if (firstBigger > secondBigger)
        {
            Console.WriteLine("The bigger number from {0},{1} and {2} is : {3}", firstNumber, secondNumber, thirdNumber, firstBigger);
        }
        else
        {
            Console.WriteLine("The bigger number from {0},{1} and {2} is : {3}", firstNumber, secondNumber, thirdNumber, secondBigger);
        }
    }
}
