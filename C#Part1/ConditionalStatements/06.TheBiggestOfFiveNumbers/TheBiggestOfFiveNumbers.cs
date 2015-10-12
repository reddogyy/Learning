/*
 Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.
 */

using System;
class TheBiggestOfFiveNumbers
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
        double fourthNumber;
        Console.Write("Please enter your fourth Number:");
        fourthNumber = double.Parse(Console.ReadLine());
        double fifthNumber;
        Console.Write("Please enter your fifth number :");
        fifthNumber = double.Parse(Console.ReadLine());
        double firstBigger;
        double secondBigger;
        if (firstNumber > secondNumber)
        {
            firstBigger = firstNumber;
        }
        else
        {
            if (secondNumber > thirdNumber)
            {
                firstBigger = secondNumber;
            }
            else
            {
                firstBigger = thirdNumber;
            }
        }
        if (fourthNumber > fifthNumber)
        {
            secondBigger = fourthNumber;
        }
        else
        {
            secondBigger = fifthNumber;
        }
        if (firstBigger > secondBigger)
        {
            Console.WriteLine("The bigger is {0}", firstBigger);
        }
        else
        {
            Console.WriteLine("The bigger number is :{0}", secondBigger);
        }
    }
}