/*Problem 6. String length

Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.
*/

using System;
class StringLength
    {
        static void Main()
        {
            Console.Write("Please enter a string : ");
            string userInput = Console.ReadLine();
            if (userInput.Length > 20)
            {
                Console.WriteLine("The entered string is more than 20 characters! ");
                return;
            }
            else
            {
                Console.WriteLine("\nResult: {0}\n", userInput.PadRight(20, '*'));
            }
        }
    }

