/*Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.
 */
using System;
class CompareArrays
{
    static void Main()
    {
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] firstArray = new int[arrayLenght];
        int[] secondArray = new int[arrayLenght];
        for (int i = 0; i != arrayLenght; i++)
        {
            int tempNumber1 = int.Parse(Console.ReadLine());
            int tempNumber2 = int.Parse(Console.ReadLine());
            firstArray[i] = tempNumber1;
            secondArray[i] = tempNumber2;
        }
        for (int p = 0; p != arrayLenght; p++)
        {

            if (firstArray[p] > secondArray[p])
            {
                Console.WriteLine("The biggest number from {0} and {1} is : {0}", firstArray[p], secondArray[p]);
            }
            else
            {
                Console.WriteLine("the biggest number from {0} and {1} is : {1}", firstArray[p], secondArray[p]);
            }
        }
    }
}

