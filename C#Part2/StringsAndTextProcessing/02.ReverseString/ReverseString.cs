using System;
using System.Text;
class ReverseString
{
    static void Main()
    {
        Console.Write("Please enter a string : ");
        string userInput = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        for (int i = userInput.Length - 1; i >= 0; i--)
        {
            sb.Append(userInput[i]);
        }

        Console.WriteLine("Reversed string is :  {0} ", sb.ToString());
    }
}

