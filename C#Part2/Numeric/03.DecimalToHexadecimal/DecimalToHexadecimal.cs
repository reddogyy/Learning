/*
 * Problem 3. Decimal to hexadecimal

Write a program to convert decimal numbers to their hexadecimal representation/
 */

using System;
class DecimalToHexadecimal
{
    static string DecimalToHex(long decimalNumber)
    {
        string hexNumber = "";
        while (decimalNumber > 0)
        {
            var digit = decimalNumber % 16;
            if (digit > 0 && digit <= 9)
            {

                hexNumber = (char)(digit + '0') + hexNumber;
            }
            else if (digit > 10 && digit <= 15)
            {
                hexNumber = (char)(digit - 10 + 'A') + hexNumber;
            }
            decimalNumber = decimalNumber / 16;
        }
        return hexNumber;
    }
    static void Main()
    {
        Console.Write("Please enter a decimal nunmber : ");
        long userInput = long.Parse(Console.ReadLine());
        Console.WriteLine("The decimal number {0} is {1} HEX", userInput, DecimalToHex(userInput));
    }
}

