/*Problem 13. Binary to Decimal Number

Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.*/


using System;
class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Please enter a binary number : ");
        string binaryNumber = Console.ReadLine();
        long decimalNumber = 0;
        int power = 1;
        for (int i = 0; i <= binaryNumber.Length; i++)
        {
            int num = binaryNumber[i] - 48;
            decimalNumber += num * power;
            power *= 2;
        }
        Console.WriteLine(decimalNumber);
    }
}
