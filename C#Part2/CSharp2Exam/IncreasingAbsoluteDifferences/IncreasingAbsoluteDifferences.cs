using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingAbsoluteDifferences
{
    class IncreasingAbsoluteDifferences
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            string[] lines = new string[numberOfLines];

            string isIncreasing = string.Empty;
            for (int i = 0; i < numberOfLines; i++)
            {
                lines[i] = Console.ReadLine();
            }
            int falseCount = 0;
            int trueCoune = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                string[] tempArray = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] differences = new int[tempArray.Length];
                for (int j = 0; j < tempArray.Length - 1; j++)
                {

                    if (int.Parse(tempArray[j + 1]) > int.Parse(tempArray[j]))
                    {
                        differences[j] = int.Parse(tempArray[j + 1]) - int.Parse(tempArray[j]);
                    }
                    else
                    {
                        differences[j] = int.Parse(tempArray[j]) - int.Parse(tempArray[j + 1]);
                    }
                }
                int finalCOunt = 0;
                if (differences[differences.Length - 1] == 0)
                {
                    finalCOunt = differences.Length - 2;
                }
                for (int h = 0; h < finalCOunt; h++)
                {

                    if (differences[h + 1] > differences[h] || differences[h + 1] == differences[h])
                    {
                        //       isIncreasing = "True";
                        if ((differences[h + 1] - differences[h]) > 1)
                        {
                            falseCount++;
                        }
                        else
                        {
                            trueCoune++;
                        }
                    }
                    else if (differences[h] > differences[h + 1])
                    {
                        //     isIncreasing = "False";
                        falseCount++;
                    }
                }
                if (falseCount != 0)
                {
                    isIncreasing = "False";
                    Console.WriteLine(isIncreasing);
                    falseCount = 0;
                }
                else
                {
                    isIncreasing = "True";
                    Console.WriteLine(isIncreasing);
                    falseCount = 0;
                }

            }

        }
    }
}
