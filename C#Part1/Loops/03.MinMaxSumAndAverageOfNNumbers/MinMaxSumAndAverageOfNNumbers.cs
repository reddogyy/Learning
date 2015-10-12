/* Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.*/


using System;
using System.Linq;
class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Please enter how many numbers will enter :");
        int numbers = int.Parse(Console.ReadLine());
        int[] numbersInput = new int[numbers];
        for (int i = 0; i != numbersInput.Length; i++)
        {
            Console.Write("please enter a number :");
            numbersInput[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("the Sum is :{0} ", numbersInput.Sum());
        Console.WriteLine("the Min is :{0} ", numbersInput.Min());
        Console.WriteLine("the Max is :{0} ", numbersInput.Max());
        double average = numbersInput.Average();
        string firstTwoDigit = average.ToString("0.00");
        Console.WriteLine("the Average  is :{0} ", firstTwoDigit);

      

    }
}
