/*Problem 4. Sub-string in text

Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
 */

using System;

class SubStringInText
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the string that we will seach for : ");
        string subString = Console.ReadLine();
        Console.Write("please enter  a text : ");
        string userInput = Console.ReadLine();
        Search(subString, userInput);
    }

    private static void Search(string subString, string userInput)
    {
        int length = 0;
        int count = 0;
        while (length != userInput.Length - subString.Length)
        {
            if (userInput.Substring(length, subString.Length) == subString)
            {
                count++;
                length++;
            }
            length++;
        }
        Console.WriteLine("The result is : {0}", count);
    }
}

