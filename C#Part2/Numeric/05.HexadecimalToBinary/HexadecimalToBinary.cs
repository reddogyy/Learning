/*Problem 5. Hexadecimal to binary

Write a program to convert hexadecimal numbers to binary numbers (directly).
 */


using System;
class HexadecimalToBinary
{
    static string ConvertToBinary(char[] hex)
    {
        for (int i = 0; i < hex.Length; i++)
        {
            hex[i] = char.ToUpper(hex[i]);
        }
        string binary = string.Empty;

        for (int i = hex.Length - 1; i >= 0; i--)
        {
            int number = (hex[i] >= 'A') ? hex[i] - 'A' + 10 : hex[i] - '0';

            int digits = 0;

            while (number > 0)
            {
                digits++;
                binary = number % 2 + binary;
                number /= 2;
            }

            binary = (i > 0 ? new string('0', 4 - digits) : "") + binary;
        }

        return binary;
    }
    static void Main()
    {
        Console.Write("Please enter a decimal nunmber : ");
        string userInput = Console.ReadLine();
        Console.WriteLine("The decimal number {0} is {1} binary", userInput, ConvertToBinary(userInput.ToCharArray()));
    }
}
