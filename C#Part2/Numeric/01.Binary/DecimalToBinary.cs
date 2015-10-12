using System;
class DecimalToBinary
{
    static string DecimalToBin(long decimalNumber)
    {
        string binaryNumber = "";
        while (decimalNumber > 0)
        {
            var digit = decimalNumber % 2;
            binaryNumber = digit + binaryNumber;
            decimalNumber = decimalNumber / 2;
        }
        return binaryNumber;
    }
    static void Main()
    {
        Console.Write("Please enter a decimal nunmber : ");
        long userInput = long.Parse(Console.ReadLine());
        Console.WriteLine("The decimal number {0} is {1} binary", userInput, DecimalToBin(userInput));
    }

}

