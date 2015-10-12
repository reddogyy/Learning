/*Problem 9. Frequent number

Write a program that finds the most frequent number in an array.
 */



using System;
class FrequentNumber
{
    static void Main()
    {
        Console.Write("Please enter the array Length : ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] myArray = new int[arrayLength];
        int mostFrequent = 1;
        int number = 0;
        int tempNumber = 0;
        int count = 1;
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("Please enter a number : ");
            myArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < myArray.Length; i++)
        {
            tempNumber = myArray[i];
            for (int j = 0; j < myArray.Length; j++)
            {


                if (tempNumber == myArray[j] && j != i)
                {
                    count++;
                    if (count > mostFrequent)
                    {
                        mostFrequent = count;
                        number = myArray[i];

                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            count = 1;

        }
        Console.Write("Most frequent number is : {0} , {1} times", number, mostFrequent);

    }
}

