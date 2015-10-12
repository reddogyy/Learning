/*Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
 */


using System;
using System.Linq;
using System.Collections.Generic;

class SortByStringLength
{
    static void Main()
    {
        Console.Write("Please enter how long will be the string array : ");
        int length = int.Parse(Console.ReadLine());
        string[] stringArray = new string[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter a string : ");
            stringArray[i] = Console.ReadLine();
        }

        var sort = from s in stringArray
                   orderby ((string)s).Length ascending
                   select s;

        List<string> sorted = new List<string>(sort); ;

        foreach (var item in sorted)
        {
            Console.WriteLine(item);
        }
    }
}

