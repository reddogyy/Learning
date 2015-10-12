using System;

class StringsAndObjects
{
    static void Main(string[] args)
    {
        String str1 = "Hello";
        String str2 = "World";
        object concatenation = str1 + " " + str2;
        String concatenated = (string)concatenation;
        Console.WriteLine(concatenated);

    }
}

