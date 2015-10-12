/*Problem 15.* Bits Exchange

Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
 */

using System;
class BitsExchange
{
    static void Main()
    {
        Console.Write("Please enter the number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        string bits = Convert.ToString(number, 2);
        // Here we create an char array with 32 values
        char[] charactersArray = new char[32];
        charactersArray = bits.ToCharArray();
        Console.WriteLine("before the change : {0}", bits);
        // making the exchange between the positions
        char tempValue1 = charactersArray[3];
        char tempValue2 = charactersArray[4];
        char tempValue3 = charactersArray[5];
        charactersArray[3] = charactersArray[24];
        charactersArray[4] = charactersArray[25];
        charactersArray[5] = charactersArray[26];
        charactersArray[24] = (char)tempValue1;            
        charactersArray[25] = (char)tempValue2;            
        charactersArray[26] = (char)tempValue3;
        string bitsExchange = new string(charactersArray);
        Console.WriteLine("the result is {0}", bitsExchange);
        Console.WriteLine(Convert.ToInt32(bitsExchange, 2));

    }
}
