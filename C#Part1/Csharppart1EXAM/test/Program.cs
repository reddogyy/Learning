using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int linesNumber = int.Parse(Console.ReadLine());
        int numberOfZeros = 0;
        int maxZero = 0;
        int maxOnes = 0;
        int numberOfOnes = 0;
        char[] bitsAsChar;
        int[] numbers = new int[linesNumber];
        string concatenatedNumbers = null;
        for (int i = 0; i < linesNumber; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < linesNumber; i++)
        {
            concatenatedNumbers = concatenatedNumbers + Convert.ToString(numbers[i], 2).PadLeft(30,'0');
        }
        bitsAsChar = concatenatedNumbers.ToCharArray();
        Console.WriteLine(bitsAsChar.Length);
        for (int i = 0; i < bitsAsChar.Length; i++)
        {
            if (bitsAsChar[i] == '0')
            {
                if (bitsAsChar[i] == bitsAsChar[i - 1])
                {
                    numberOfZeros++;
                    if (numberOfZeros > maxZero)
                    {
                        maxZero = numberOfZeros;
                    }
                }
                numberOfOnes = 0;
            }
            else
            {
                
                if (bitsAsChar[i] == bitsAsChar[i - 1])
                {
                    numberOfOnes++;
                    if (numberOfOnes > maxOnes)
                    {
                        maxOnes = numberOfZeros;
                    }
                    
                }
                numberOfZeros = 0;
            }
        }
        Console.WriteLine(numberOfOnes);
        Console.WriteLine(numberOfZeros);


    }
}

