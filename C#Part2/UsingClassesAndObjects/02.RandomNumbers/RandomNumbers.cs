/*Problem 2. Random numbers

Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */

using System;


class RandomNumbers
{
    static Random rand = new Random();
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Here is a random number between 100 and 200 : {0}\n", rand.Next(100, 201));
        }
    }
}
