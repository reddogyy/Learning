/*Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).
 */

using System;
class CompareCharArrays
{
    static void Main()
    {
        int arrayLenght = int.Parse(Console.ReadLine());
        char[] firstChar = new char[arrayLenght];
        char[] secondChar = new char[arrayLenght];

        for (int i = 0; i != arrayLenght; i++)
        {
            firstChar[i] = char.Parse(Console.ReadLine());
            secondChar[i] = char.Parse(Console.ReadLine());
        }
        for (int p = 0; p != arrayLenght; p++)
        {
            if (firstChar[p] > secondChar[p])
            {
                Console.WriteLine("The biggest from {0} and {1} is  :{0}", firstChar[p], secondChar[p]);
            }
            else
            {
                Console.WriteLine("The biggest from {0} and {1} is : {1} ", firstChar[p], secondChar[p]);
            }
        }
    }
}

