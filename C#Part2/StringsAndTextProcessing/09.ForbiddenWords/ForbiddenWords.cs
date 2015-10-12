/*Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
 */

using System;
using System.Text;
using System.Text.RegularExpressions;


    class ForbiddenWords
    {
        static void Main()
        {
            Console.Write("please enter text : ");
            string userInput = Console.ReadLine();
            Console.Write("Please enter how many forbiden words we have : ");
            int forbidenWordsNumber = int.Parse(Console.ReadLine());
            string[] forbidenWords = new string[forbidenWordsNumber];
            for (int i = 0; i < forbidenWords.Length; i++)
            {
                Console.Write("Please enter the forbiden word : ");
                forbidenWords[i] = Console.ReadLine();
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < forbidenWords.Length; i++)
            {
                int temp = forbidenWords[i].Length;
                for (int j = 0; j < temp; j++)
                {
                    sb.Append('*');
                }
                string tempString = sb.ToString();
                    userInput = Regex.Replace(userInput, forbidenWords[i], word => tempString);
            }
            Console.WriteLine("The result is : {0}", userInput);
        }
    }

