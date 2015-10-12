﻿/*Problem 5. Parse tags

You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class ParseTags
{
    static void Main()
    {
        Console.Write("please enter text : ");
        string userInput = Console.ReadLine();
        Console.WriteLine(Regex.Replace(userInput, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper()));
    }
}

