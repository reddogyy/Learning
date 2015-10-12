/*Problem 8. Replace whole word

Modify the solution of the previous problem to replace only whole words (not strings).
 */

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
class ReplaceWholeWord
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

                    while (line != null)
                    {
                        line = Regex.Replace(line, @"\start\b", "finish");
                        writer.WriteLine(line);
                        line = reader.ReadLine();
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
