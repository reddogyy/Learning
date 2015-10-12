/*Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).
 */

using System;
class FindSumInArray
{
    static void Main()
    {
        Console.Write("Please enter the sum we will serch for : ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Please enter the array Length : ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] myArray = new int[arrayLength];
        int sum = 0;
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("Please enter a number : ");
            myArray[i] = int.Parse(Console.ReadLine());
        }
        bool solution = false;
        for (int i = 0; i < arrayLength; i++)
        {
            for (int j = i; j < arrayLength; j++)
            {
                sum += myArray[j];
                if (sum == s)
                {
                    solution = true;
                    Console.Write("The following sequence has the sum of {0}: ", s);
                    for (int print = i; print <= j; print++)
                    {
                        Console.Write("{0} ", myArray[print]);
                    }
                    Console.WriteLine();
                }
            }
            sum = 0;
        }
        if (!solution)
        {
            Console.WriteLine("Ain't no sequnce with the sum of {0}!", s);
        }
    }
}

