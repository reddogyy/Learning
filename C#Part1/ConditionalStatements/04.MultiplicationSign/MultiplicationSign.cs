/* Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
 */

using System;

class MultiplicationSign
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
        if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The final result will be +");
        }
        else if (firstNumber < 0 || secondNumber < 0 || thirdNumber < 0)
        {
            Console.WriteLine("The final result will be -");
        }
        else if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The final result will be 0");
        }

    }
}
