/* Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
 */

using System;
class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Please enter the length of the array : ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[arrayLength];
        int length = 1;
        int bestLength = 0;
        int startPosition = 0;
        for (int i = 0; i < numbersArray.Length; i++)
        {
            numbersArray[i] = int.Parse(Console.ReadLine());
        }
        for (int s = 1; s < numbersArray.Length; s++)
        {
            if (numbersArray[s - 1] > numbersArray[s])
            {
                length++;
                if (bestLength < length)
                {
                    startPosition = (s - length)-1;
                    bestLength = length;
                }
                continue;
            }
            else
            {
                length = 1;
            }
        }
        for (int j = startPosition; j < bestLength; j++)
        {
            Console.Write("{0} ", numbersArray[j]);
        }
    }
}
