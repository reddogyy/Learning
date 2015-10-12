/*Problem 5. Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7.*/

using System;
class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Third Digit is 7? ");
        int inputNumber;
        Console.WriteLine("Please enter a number: ");
        inputNumber = int.Parse(Console.ReadLine());
        int result;
        result = inputNumber / 100;
        result = result % 10;
        if (result == 7)
        {
            Console.WriteLine("Your third digit is 7!");
        }
        else
        {
            Console.WriteLine("Error ! Your third digit is not 7!");
        }

    }
}

