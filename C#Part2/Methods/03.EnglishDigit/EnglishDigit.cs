/*Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.
 */

using System;
class EnglishDigit
{
    static string LastDigit(string number)
    {
        string lastDigit = string.Empty ;
        char lastChar;
        int digit = number.Length - 1;
        lastChar = number[digit];
        switch (lastChar)
        {
            case '1':
                {
                    lastDigit = "one";
                    break;

                }
            case '2':
                {
                    lastDigit = "two";
                    break;

                }
            case '3':
                {
                    lastDigit = "three";
                    break;

                }
            case '4':
                {
                    lastDigit = "four";
                    break;

                }
            case '5':
                {
                    lastDigit = "five";
                    break;

                }
            case '6':
                {
                    lastDigit = "six";
                    break;

                }
            case '7':
                {
                    lastDigit = "seven";
                    break;

                }
            case '8':
                {
                    lastDigit = "eight";
                    break;

                }
            case '9':
                {
                    lastDigit = "nine";
                    break;

                }
            case '0':
                {
                    lastDigit = "zero";
                    break;

                }
            default:
                break;
        }


        return lastDigit;

    }
    static void Main()
    {
        Console.Write("Please enter a number :");
        string userInput = Console.ReadLine();
        Console.WriteLine(LastDigit(userInput));

    }
}
