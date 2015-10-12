/*Problem 6. binary to hexadecimal

Write a program to convert binary numbers to hexadecimal numbers (directly).
 */
using System;
class BinaryToHexademical
{
    static string ConvertToHexadecimal(string binary)
    {
        string hex = string.Empty;

        for (int i = binary.Length - 1; i >= 0; )
        {
            int number = 0, j = 0;

            for (int pow = 1; j < 4 && i - j >= 0; j++, pow *= 2)
                number += (binary[i - j] - 48) * pow;

            i -= j;

            hex = number >= 10 ? (char)('A' + number - 10) + hex : number + hex;
        }

        return hex;
    }
    static void Main()
    {
        Console.Write("Please enter a binary nunmber : ");
        string userInput = Console.ReadLine();
        Console.WriteLine("The binary number {0} is {1} HEX", userInput, ConvertToHexadecimal(userInput));
    }
}

