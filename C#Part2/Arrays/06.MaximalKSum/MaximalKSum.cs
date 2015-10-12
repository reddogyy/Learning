/*Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
 */
using System;
class MaximalKSum
{
    static void Main()
    {
        Console.Write("Please enter a number N:");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("PLease enter a number K: ");
        int numberK = int.Parse(Console.ReadLine());
        int[] numbersArray= new int[numberN];
        for (int i = 0; i < numberN; i++)
        {
            numbersArray[i] = int.Parse(Console.ReadLine());
        }
        int[] numbersSum = new int[numberN];
        int startPosition = 0;
        int tempSum =0;
        for (int i = 0; i < numberN; i++)
        {
            for (int j = startPosition; j < numberK; j++)
            {
                tempSum += numbersArray[j];
            }
            numbersSum[i] = tempSum;
            startPosition++;
        }
        int index = -1;
        int? maxVal = null;
        for (int i = 0; i < numbersSum.Length; i++)
        {
            int thisNum = numbersSum[i];
            if (!maxVal.HasValue || thisNum > maxVal.Value)
            {
                maxVal = thisNum;
                index = i;
            }
        }
        Console.WriteLine("The maximal sum of {0} following numbers is : {1}",numberK,maxVal);


    }
}
