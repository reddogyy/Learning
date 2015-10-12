/*Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
Example:

input	output
"43 68 9 23 318"	461
 */

using System;

class SumIntegers
{

    static void Main()
    {
        Console.Write("Please enter integers separeted by space :");
        string userInput = Console.ReadLine();
        string[] integers = userInput.Split(' ');
        int sum = 0;
        for (int i = 0; i < integers.Length; i++)
        {
            sum += int.Parse(integers[i]);
        }
        Console.WriteLine("The sum of the integers is : {0}", sum);
    }
}

