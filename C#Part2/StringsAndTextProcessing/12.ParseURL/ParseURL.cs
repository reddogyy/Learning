/*Problem 12. Parse URL

Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 */
using System;
using System.Text.RegularExpressions;


class ParseURL
{
    static void Main()
    {
        string urlAddress = @"http://telerikacademy.com/Courses/Courses/Details/212";

        var fragments = Regex.Match(urlAddress, "(.*)://(.*?)(/.*)").Groups;

        Console.WriteLine("URL Address: {0}", urlAddress);
        Console.WriteLine("\n[protocol] = {0}", fragments[1]);
        Console.WriteLine("[server] = {0}", fragments[2]);
        Console.WriteLine("[resource] = {0}\n", fragments[3]);
    }
}

