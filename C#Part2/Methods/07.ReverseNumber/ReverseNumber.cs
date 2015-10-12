/*Problem 7. Reverse number

Write a method that reverses the digits of given decimal number.
 */

using System;
using System.Text;
class ReverseNumber
{
    static string Reverse(string number)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = number.Length - 1; i >= 0; i--)
        {
            sb.Append(number[i]);
        }
        return sb.ToString();
    }

    static void Main()
    {
        Console.WriteLine("Please enter a number :");
        string userInput = Console.ReadLine();
        Console.WriteLine(Reverse(userInput));

    }
}

