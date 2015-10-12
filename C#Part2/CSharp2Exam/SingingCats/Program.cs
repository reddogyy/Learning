using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SingingCats
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new List<string>();
            bool isTrue = true;
            while (isTrue)
            {
                string temp = Console.ReadLine();

                if (temp == "Mew!")
                {
                    isTrue = false;
                }
                else
                {
                    sb.Add(temp);
                }
            }
            string[] userInput = sb.ToArray();

            char[] numbers = new char[userInput.Length];
            for (int i = 0; i < userInput.Length; i++)
            {
                numbers = (from t in userInput[i]
                           where char.IsDigit(t)
                           select t).ToArray();
                Console.WriteLine(numbers);
            }
            char cats = numbers[0];
            char songs = numbers[1];
            for (int i = 0; i < 2; i++)
            {
                numbers = numbers.Where((source, index) => index != 0).ToArray();
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            List<char> songConcert = new List<char>(numbers);
            int[,] concert = new int[cats, songs];
   //         char[] song = new char[numbers.Length - 2];
     //      for (int i = 0; i < song.Length; i++)
     //      {
     //          song[i] = numbers[i + 2];
     //          Console.WriteLine(song[i]);
     //      }
        }
    }
}
