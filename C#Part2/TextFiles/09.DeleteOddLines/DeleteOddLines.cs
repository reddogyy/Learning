﻿/*Problem 9. Delete odd lines

Write a program that deletes from given text file all odd lines.
The result should be in the same file.
 */

using System;
using System.IO;
using System.Text;
class DeleteOddLines
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("../../test.txt", Encoding.GetEncoding("UTF-8"));
            StreamWriter writer = new StreamWriter("../../temp.txt", false, Encoding.GetEncoding("UTF-8"));

            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    int cnt = 1;

                    while (line != null)
                    {
                        if (cnt % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }
                        line = reader.ReadLine();
                        cnt++;
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
