/*Problem 14. Decimal to Binary Number

Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
 */

using System;
class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Please enter a decimal number : ");
        long decimalNumber = long.Parse(Console.ReadLine());
        long tempNumber = 0;
        string binaryNumber = "";
        while (decimalNumber != 0)
        {
            tempNumber = decimalNumber % 2;
            decimalNumber = decimalNumber / 2;
            binaryNumber = tempNumber + binaryNumber;
        }
        Console.WriteLine("The binary number is : {0}", binaryNumber);
    }
}

