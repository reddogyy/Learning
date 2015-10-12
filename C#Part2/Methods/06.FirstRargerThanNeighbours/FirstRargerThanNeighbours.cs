/*Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise
 */

using System;
class FirstRargerThanNeighbours
    {
    static int LargestThanNeighbour(int[] numbersArray)
    {
        for (int i = 1; i < numbersArray.Length-1; i++)
        {
            if (numbersArray[i] > numbersArray[i - 1] && numbersArray[i] > numbersArray[i + 1])
            {
                return i;
            }
        }
            return -1;
    }
        static void Main()
        {
            Console.Write("Please enter how long will be the array :");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] userInput = new int[arrayLength];
            Console.WriteLine("Please now fill the array :");
            for (int i = 0; i < userInput.Length; i++)
            {
                userInput[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The Largest number than neighbours is on position : {0}", LargestThanNeighbour(userInput));
        }
    }

