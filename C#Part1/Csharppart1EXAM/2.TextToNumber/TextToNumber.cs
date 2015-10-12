using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TextToNumber
{
    static void Main()
    {
//        StreamReader reader = new StreamReader("..\\..\\input.txt");
  //      Console.SetIn(reader);

        int numberM = int.Parse(Console.ReadLine());
        string userInput = Console.ReadLine();
        int lenght = userInput.Length;
        string upperUserInput = userInput.ToUpper();
        long result = 0;
        Console.WriteLine(upperUserInput);
        for (int i = 0; i != lenght; i++)
        {
            long tempResult = result;
            string sub = userInput.Substring(i, i);
            int number;
            Int32.TryParse(sub, out number);
      //      bool isDigit = number == 1 | 2 | 3 | 4 | 5 | 6 | 7| 8 | 9 | 0;
            Console.WriteLine(number);
            char tempUpperChar = upperUserInput[i];
            char tempUserChar = userInput[i];
            long charNumber = 0;

            #region Chars
     //     switch (tempUpperChar)
     //     {
     //         case ('A'):
     //             {
     //                 charNumber = 0;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('B'):
     //             {
     //                 charNumber = 1;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('C'):
     //             {
     //                 charNumber = 2;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('D'):
     //             {
     //                 charNumber = 3;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('E'):
     //             {
     //                 charNumber = 4;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('F'):
     //             {
     //                 charNumber = 5;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('G'):
     //             {
     //                 charNumber = 6;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('H'):
     //             {
     //                 charNumber = 7;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('I'):
     //             {
     //                 charNumber = 8;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('J'):
     //             {
     //                 charNumber = 9;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('K'):
     //             {
     //                 charNumber = 10;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('L'):
     //             {
     //                 charNumber = 11;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('M'):
     //             {
     //                 charNumber = 12;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('N'):
     //             {
     //                 charNumber = 13;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('O'):
     //             {
     //                 charNumber = 14;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('P'):
     //             {
     //                 charNumber = 15;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('Q'):
     //             {
     //                 charNumber = 16;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('R'):
     //             {
     //                 charNumber = 17;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('S'):
     //             {
     //                 charNumber = 18;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('T'):
     //             {
     //                 charNumber = 19;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('U'):
     //             {
     //                 charNumber = 20;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('V'):
     //             {
     //                 charNumber = 21;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('W'):
     //             {
     //                 charNumber = 22;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('X'):
     //             {
     //                 charNumber = 23;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('Y'):
     //             {
     //                 charNumber = 24;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('Z'):
     //             {
     //                 charNumber = 25;
     //                 result = tempResult + charNumber;
     //                 Console.WriteLine("RESULT = {0} +{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('@'):
     //             {
     //                 break;
     //             }
     //         case ('0'):
     //             {
     //                 charNumber = 0;
     //                 result = tempResult * charNumber;
     //                 Console.WriteLine("RESULT = {0} *{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('1'):
     //             {
     //                 charNumber = 1;
     //                 result = tempResult * charNumber;
     //                 Console.WriteLine("RESULT = {0} *{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('2'):
     //             {
     //                 charNumber = 2;
     //                 result = tempResult * charNumber;
     //                 Console.WriteLine("RESULT = {0} *{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('3'):
     //             {
     //                 charNumber = 3;
     //                 result = tempResult * charNumber;
     //                 Console.WriteLine("RESULT = {0} *{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('4'):
     //             {
     //                 charNumber = 4;
     //                 result = tempResult * charNumber;
     //                 Console.WriteLine("RESULT = {0} *{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('5'):
     //             {
     //                 charNumber = 5;
     //                 result = tempResult * charNumber;
     //                 Console.WriteLine("RESULT = {0} *{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('6'):
     //             {
     //                 charNumber = 6;
     //                 result = tempResult * charNumber;
     //                 Console.WriteLine("RESULT = {0} *{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('7'):
     //             {
     //                 charNumber = 7;
     //                 result = tempResult * charNumber;
     //                 Console.WriteLine("RESULT = {0} *{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('8'):
     //             {
     //                 charNumber = 8;
     //                 result = tempResult * charNumber;
     //                 Console.WriteLine("RESULT = {0} *{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         case ('9'):
     //             {
     //                 charNumber = 9;
     //                 result = tempResult * charNumber;
     //                 Console.WriteLine("RESULT = {0} *{1}({2}) = {3}", tempResult, charNumber, tempUserChar, result);
     //                 break;
     //             }
     //         default:
     //             {
     //                 result = tempResult % numberM;
     //                 Console.WriteLine("RESULT = {0} %{1}({2}) = {3}", tempResult, numberM, tempUserChar, result);
     //                 break;
     //             }



        //    }
            #endregion
        }

    }
}

