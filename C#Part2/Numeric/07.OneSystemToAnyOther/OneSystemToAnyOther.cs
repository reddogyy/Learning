/*Problem 7. One system to any other

Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
 */

using System;
class OneSystemToAnyOther
{
    static string DecimalToBase(long decimalNumber, int numeralSystem)
    {
        string result = "";
        while (decimalNumber > 0)
        {
            var digit = decimalNumber % numeralSystem;
            if (digit > 0 && digit <= 9)
            {

                result = (char)(digit + '0') + result;
            }
            else
            {
                result = (char)(digit - 10 + 'A') + result;
            }
            decimalNumber /= numeralSystem;
        }
        return result;
    }

    static long BaseToDecimal(string baseNumber, int numeralSystem)
    {
        long decimalNumber = 0;
        for (int i = 0; i < baseNumber.Length; i++)
        {
            int digit = 0;
            if (baseNumber[i] > '0' && baseNumber[i] <= '9')
            {

                digit = baseNumber[i] - '0';
            }
            else
            {
                digit = baseNumber[i] - 'A' + 10;
            }
            int position = baseNumber.Length - i - 1;
            decimalNumber += digit * (long)Math.Pow(numeralSystem, position);
        }
        return decimalNumber;
    }

    static void Main()
    {
        Console.Write("Please enter a number :");
        string firstNumber = Console.ReadLine();
        Console.Write("Please enter the starting base of  number :");
        int firstBase = int.Parse(Console.ReadLine());
        Console.Write("Please enter the final base of  number :");
        int secondBase = int.Parse(Console.ReadLine());
        if ((firstBase < 2 || firstBase > 16) || (secondBase < 2 || secondBase > 16))
        {
            Console.WriteLine("The entered bases are not in the range from 2 to 16 !");
            return;
        }
        Console.WriteLine(DecimalToBase(BaseToDecimal(firstNumber, firstBase), secondBase));
    }
}
