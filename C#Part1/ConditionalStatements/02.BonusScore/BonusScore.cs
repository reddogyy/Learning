/*Problem 2. Bonus Score

Write a program that applies bonus score to given score in the range [1…9] by the following rules:
If the score is between 1 and 3, the program multiplies it by 10.
If the score is between 4 and 6, the program multiplies it by 100.
If the score is between 7 and 9, the program multiplies it by 1000.
If the score is 0 or more than 9, the program prints “invalid score”.
 */

using System;
class BonusScore
{
    static void Main()
    {
        int score;
        Console.Write("Please enter your scores : ");
        score = int.Parse(Console.ReadLine());
        int result = 0;
        if (1 <= score && score <= 3)
        {
            result = score * 10;
            Console.WriteLine("Your result is {0}", result);
        }
        else if (4 <= score && score <= 6)
        {
            result = score * 100;
            Console.WriteLine("Your result is {0}", result);
        }
        else if (7 <= score && score <= 9)
        {
            result = score * 1000;
            Console.WriteLine("Your result is {0}", result);
        }
        else if (0 >= score || score >= 10)
        {
            Console.WriteLine("Invalid Score! ");
        }

    }
}
