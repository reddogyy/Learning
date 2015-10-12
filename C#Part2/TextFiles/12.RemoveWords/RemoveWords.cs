﻿/*Problem 12. Remove words

Write a program that removes from a text file all words listed in given another text file.
Handle all possible exceptions in your methods.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


class RemoveWords
{
    static void Main(string[] args)
    {
        List<string> words = new List<string>();

        try
        {
            StreamReader reader1 = new StreamReader("../../test.txt", Encoding.GetEncoding("UTF-8"));
            StreamReader reader2 = new StreamReader("../../words.txt", Encoding.GetEncoding("UTF-8"));
            StreamWriter writer = new StreamWriter("../../temp.txt", false, Encoding.GetEncoding("UTF-8"));

            using (reader2)
            {
                string line = reader2.ReadLine();

                while (line != null)
                {
                    words.Add(line);
                    line = reader2.ReadLine();
                }
            }

            using (reader1)
            {
                using (writer)
                {
                    string line = reader1.ReadLine();

                    while (line != null)
                    {
                        foreach (string word in words)
                        {
                            line = Regex.Replace(line, word, "");
                        }

                        writer.WriteLine(line);
                        line = reader1.ReadLine();
                    }
                }
            }


            File.Delete("../../test.txt");
            File.Move("../../temp.txt", "../../test.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Can not find file!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Invalid directory in the file path!");
        }
        catch (IOException)
        {
            Console.WriteLine("Can not open the file!");
        }
    }
}
