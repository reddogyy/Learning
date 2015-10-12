/*Problem 7. Selection sort

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 */


using System;
class SelectionSort
{
    static void Main()
    {
        Console.Write("Please enter how long will be the array : ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[arrayLength];
        for (int i = 0; i < numbersArray.Length; i++)
        {
            Console.Write("Please enter a number : ");
            numbersArray[i] = int.Parse(Console.ReadLine());
        }
        int min;
        int temp;
        for (int i = 0; i < numbersArray.Length - 1; i++)
        {
            min = i;
            for (int j = i + 1; j < numbersArray.Length; j++)
            {
                if (numbersArray[j] < numbersArray[min])
                {
                    min = j;
                }
            }
            temp = numbersArray[i];
            numbersArray[i] = numbersArray[min];
            numbersArray[min] = temp;
        }
        for (int i = 0; i < numbersArray.Length; i++)
        {
            Console.WriteLine(numbersArray[i]);
        }
    }
}

