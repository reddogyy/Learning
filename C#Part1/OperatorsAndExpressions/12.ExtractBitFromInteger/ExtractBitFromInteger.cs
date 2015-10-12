/*Problem 12. Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p.
 */

using System;
class ExtractBitFromInteger
{
    static void Main()
    {

        int number;
        Console.WriteLine("Please enter a number : ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the the possition :");
        int position;
        position = int.Parse(Console.ReadLine());
        string bits = Convert.ToString(number, 2);
        int lenght = bits.Length;
        char[] characters = bits.ToCharArray(0, lenght);
        Console.WriteLine(Convert.ToChar(characters[position]));
    }
}

