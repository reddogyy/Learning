
/*Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.
 */

using System;
class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Four-Digit Number!");
        int firstDigit;
        int secondDigit;
        int thirdDigit;
        int fourthDigit;
        Console.WriteLine("Please enter first digit number : ");
        firstDigit = int.Parse(Console.ReadLine());
        if (firstDigit == 0)
        {
            Console.WriteLine("The Four-Digit number cannot start with 0-zero");
            return ;
        }
        Console.WriteLine("Please enter the second number : ");
        secondDigit = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your third number : ");
        thirdDigit = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the last, fourth digit : ");
        fourthDigit = int.Parse(Console.ReadLine());
        int result = firstDigit + secondDigit + thirdDigit + fourthDigit;
        Console.WriteLine("The result of the digits from number {0}{1}{2}{3}, is :{4}", firstDigit, secondDigit, thirdDigit, fourthDigit, result);
        Console.WriteLine("Reversed number is {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
        Console.WriteLine("Last digit on first place {3}{0}{1}{2}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("Exchanged second and third digit {0}{2}{1}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
    }
}
