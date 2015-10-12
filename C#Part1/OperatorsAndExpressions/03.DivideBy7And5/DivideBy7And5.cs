/*Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time. */

using System;


class DivideBy7And5
{
    static void Main()
    {
        int firstNumber;
        Console.WriteLine("Please enter a number and pres enter:");
        firstNumber=Convert.ToInt32(Console.ReadLine());
        bool isDivideBy5;
        bool isDivideBy7;
        if ((firstNumber % 5)==0)
        {
            isDivideBy5 = true;
        }
        else
        {
            isDivideBy5 = false;
        }
        if ((firstNumber % 7) == 0)
        {
            isDivideBy7 = true;
        }
        else
        {
            isDivideBy7 = false;
        }
        bool isDivide = isDivideBy5 && isDivideBy7;
        Console.WriteLine("is the number {0} divided by 5 and 7 : {1}",firstNumber,isDivide);

    }
}

