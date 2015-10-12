/*Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
 */

using System;
class MaximalSequence
{
    static void Main()
    {
        Console.Write("Please enter the lenght of the array : ");
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[arrayLenght];
        int length = 1;
        int bestLenght = 1;
        for (int i = 0; i < numbersArray.Length; i++)
        {
            Console.Write("Please enter a number : ");
            numbersArray[i] = int.Parse(Console.ReadLine());
        }
        int currNum = numbersArray[0];
        for (int s = 1; s < numbersArray.Length; s++)
        {
            if (numbersArray[s] == currNum)
            {
                length++;

                if (bestLenght < length)
                {
                    bestLenght = length;
                    currNum = numbersArray[s];
                }
            }
        else
            {
                length = 1;
                currNum = numbersArray[s];
            }
            
        }
        for (int j = 0; j < bestLenght; j++)
        {
            Console.Write(currNum);
        }
        Console.WriteLine();
    }
}

