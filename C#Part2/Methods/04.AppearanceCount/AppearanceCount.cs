/*Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
 */


using System;
class AppearanceCount
{
    static int MostFrequent()
    {
        int mostFrequent = 1;
        int number = 0;
        int tempNumber = 0;
        int count = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            tempNumber = numbers[i];
            for (int j = 0; j < numbers.Length; j++)
            {


                if (tempNumber == numbers[j] && j != i)
                {
                    count++;
                    if (count > mostFrequent)
                    {
                        mostFrequent = count;
                        number = numbers[i];

                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            count = 1;

        }
        return  mostFrequent;
    }

    static void Main()
    {
        Console.Write("Please enter the array Length : ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] myArray = new int[arrayLength];
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("Please enter a number : ");
            myArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The most frequent number appear {0} times", MostFrequent(myArray));
        
    }
}

