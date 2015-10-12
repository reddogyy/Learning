/*Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.
 */

using System;
using System.Text;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Please enter the array Length : ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] myArray = new int[arrayLength];
        int currentSum = 0;
        int bestSum = int.MinValue;
        StringBuilder bestSequenceBuild = new StringBuilder();
        string bestSequnce = "";
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Please enter a number : ");
            myArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < myArray.Length; i++)
        {
            currentSum = currentSum + myArray[i];
            bestSequenceBuild.AppendFormat("{0}, ", myArray[i]);
            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                bestSequnce = bestSequenceBuild.ToString();
            }
            if (currentSum < 0)
            {
                currentSum = 0;
                bestSequenceBuild.Clear();
            }
        }
        Console.WriteLine("The best sequence is: \" {0} \" ", bestSequnce);
        Console.WriteLine("The best sum is: {0} ", bestSum);
    }
}