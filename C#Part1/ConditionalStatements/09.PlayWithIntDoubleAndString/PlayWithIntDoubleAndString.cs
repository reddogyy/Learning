/*Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
 */

using System;
class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Choose 1 for int.");
        Console.WriteLine("Choose 2 for double.");
        Console.WriteLine("Choose 3 for string. ");
        Console.Write("Please enter your choise: ");
        int userInput = int.Parse(Console.ReadLine());
        int userInt = 0;
        double userDouble = 0d;
        string userString = null;
        switch (userInput)
        {
            case 1:
                Console.Write("Please enter an interger:");
                userInt = int.Parse(Console.ReadLine());
                Console.WriteLine("Your result is :{0}", ++userInt);
                break;
            case 2:
                Console.Write("Please enter an interger:");
                userDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("Your result is :{0}", ++userDouble);
                break;
            case 3:
                Console.Write("Please enter an interger:");
                userString = Console.ReadLine();
                Console.WriteLine("Your result is :{0}*", userString);
                break;
            default:
                Console.WriteLine("the number you enterd doesn't exist at the moment!");
                break;

        }
    }
}

