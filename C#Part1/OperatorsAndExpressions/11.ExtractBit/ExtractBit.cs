/*Problem 11. Bitwise: Extract Bit #3

Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
 */

using System;

class Program
{
    static void Main()
    {
        uint number;
        Console.WriteLine("Please enter a number : ");
        number = uint.Parse(Console.ReadLine());
        string bits = Convert.ToString(number, 2);
        int lenght = bits.Length;
        char[] characters = bits.ToCharArray(0,lenght);


        Console.WriteLine(Convert.ToChar(characters[3]));
    }
}
