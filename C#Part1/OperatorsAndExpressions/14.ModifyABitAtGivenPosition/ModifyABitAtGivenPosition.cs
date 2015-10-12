/*Problem 14. Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
 */

using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {

        Console.Write("Please enter the number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter a position that you want to change: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Please enter a bit value to be changed (0 or 1) : ");
        int bitValue = int.Parse(Console.ReadLine());


        if (bitValue == 1)
        {
            int setOne = 1 << position;
            int foundBitOne = number | setOne;
            Console.WriteLine(Convert.ToString(foundBitOne, 2).PadLeft(16, '0'));
            Console.WriteLine("Result: " + foundBitOne);
        }
        else
        {
            int setZero = ~(1 << position);
            int foundBitZero = number & setZero;
            Console.WriteLine(Convert.ToString(foundBitZero, 2).PadLeft(16, '0'));
            Console.WriteLine("Result: " + foundBitZero);
        }
        


    }

}

