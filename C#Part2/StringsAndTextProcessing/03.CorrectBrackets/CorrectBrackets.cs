/*Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */

using System;

class CorrectBrackets
{
    static bool IsValidExpression(string exp)
    {
        int brackets = 0;

        for (int i = 0; i < exp.Length; i++)
        {
            if (exp[i] == '(') 
            {
                brackets++; 
            }
            else if (exp[i] == ')') 
            {
                brackets--; 
            }

            if (brackets < 0)
            {
                return false;
            }
        }

        if (brackets != 0) 
        {
            return false;
        }
        return true;
    }
    static void Main()
    {
        Console.Write("Please enter an expresion (excample )(a*b)+b) ) : ");
        string userInput = Console.ReadLine();

        Console.WriteLine("\nThe expression is {0}!\n", IsValidExpression(userInput));
    }
}

