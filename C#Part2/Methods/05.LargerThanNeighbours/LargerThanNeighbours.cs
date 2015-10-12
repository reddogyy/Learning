/*Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
 */


using System;
class LargerThanNeighbours
{
    static bool LargestThanNeighbour(int[] numbersArray, int position)
    {
        bool isLargest = false;
        int tempPosition = position - 1;
        if (numbersArray[tempPosition] > numbersArray[tempPosition - 1] && numbersArray[tempPosition] > numbersArray[tempPosition + 1])
        {
            isLargest = true;
        }
        else
        {
            isLargest = false;
        }

        return isLargest;
    }

    static void Main()
    {
        Console.Write("Please enter how long will be the array :");
        int arrayLength = int.Parse(Console.ReadLine());
        Console.Write("Please enter the postion which we will check :");
        int index = int.Parse(Console.ReadLine());
        if (index > arrayLength && index + 1 > arrayLength)
        {
            Console.WriteLine("You try to search unexisting index!");
            return;
        }

        int[] userInput = new int[arrayLength];
        Console.WriteLine("Please now fill the array :");
        for (int i = 0; i < userInput.Length; i++)
        {
            userInput[i] = int.Parse(Console.ReadLine());

        }
        Console.WriteLine("is the number largers than neighbours : {0}", LargestThanNeighbour(userInput, index));
    }
}

