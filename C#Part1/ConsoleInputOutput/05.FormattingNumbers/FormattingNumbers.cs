/*Problem 5. Formatting Numbers

Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
 */

using System;
class FormattingNumbers
{
    static void Main()
    {
        int firstNumber;
        float secondNumber;
        float thirdNumber;
        Console.Write("Please enter your first number :");
        firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter your second number :");
        secondNumber = float.Parse(Console.ReadLine());
        Console.Write("Please enter your third number : ");
        thirdNumber = float.Parse(Console.ReadLine());
        string bitsFirstNumber = Convert.ToString(firstNumber, 2).PadLeft(10, '0');
        Console.WriteLine("{0:X}|{3}|{1,-10:F2}|{2:F3} ", firstNumber, secondNumber, thirdNumber,bitsFirstNumber);
    }
}
