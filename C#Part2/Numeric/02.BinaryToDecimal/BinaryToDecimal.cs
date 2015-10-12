/*Problem 2. Binary to decimal

Write a program to convert binary numbers to their decimal representation.
 */

using System;
class BinaryToDecimal
{
    static long BinaryToDec(string BinaryNumber)
    {
        long decimalNumber = 0;
        for (int i = 0; i < BinaryNumber.Length; i++)
        {
            int digit = BinaryNumber[i] - '0';
            int position = BinaryNumber.Length - i - 1;
            decimalNumber += digit * (long)Math.Pow(2, position);
        }
        return decimalNumber;
    }
    static void Main()
    {
        Console.Write("Please enter a binary nunmber : ");
        string userInput = Console.ReadLine();
        Console.WriteLine("The binary number {0} is {1} decimal", userInput, BinaryToDec(userInput));
    }
}

