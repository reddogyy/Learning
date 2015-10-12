/*Problem 13. Check a Bit at Given Position

Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
 */

using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        int number;
        Console.WriteLine("Please enter a number : ");
        number = int.Parse(Console.ReadLine());
        int position;
        Console.WriteLine("Please enter the the possition :");
        position = int.Parse(Console.ReadLine());
        string bits = Convert.ToString(number, 2);
        char[] charactersArray = bits.ToCharArray();
        int result = (int)char.GetNumericValue(charactersArray[position]);
        bool isEqual = false;
        if (result == 1)
        {
            isEqual = true;
        }
        else
        {
            isEqual = false;
        }
        Console.WriteLine("The bit at position {0} is equal to 1 : {1}", position, isEqual);


    }
}
