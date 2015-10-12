using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;


namespace _1.De_cat_coding
{
    class DeCatCoding
    {

        static string[] DecimalToBase(BigInteger decimalNumber, uint numeralSystem)
        {
            List<string> sb = new List<string>();
            while (decimalNumber > 0)
            {
                BigInteger digit = decimalNumber % numeralSystem;


                    sb.Add(digit.ToString());
                
           
                decimalNumber /= numeralSystem;
            }
            return sb.ToArray();
        }

        static BigInteger Pow(BigInteger numeralSystem, BigInteger position)
        {
            BigInteger result = 1;
            for (int i = 0; i < position; i++)
            {
                result *= numeralSystem;
            }
            return result;
        }
        static BigInteger BaseToDecimal(string[] baseNumber, int numeralSystem)
        {
            BigInteger decimalNumber = 0;
            for (int i = 0; i < baseNumber.Length; i++)
            {
                int position = baseNumber.Length - i - 1;
                BigInteger digit = 0;
                if (position == 0)
                {

                    digit = BigInteger.Parse(baseNumber[i]);
                }
                else
                {
                    digit = BigInteger.Parse(baseNumber[i]) * Pow(numeralSystem,position);
                }
                decimalNumber += digit;
            }
            return decimalNumber;
        }

        static string NumbersToAlphabet(string[] numbersInput)
      {
          StringBuilder sb = new StringBuilder();
          for (int i = numbersInput.Length -1; i >=0; i--)
          {
              string a = numbersInput[i];
  
              switch (a)
              {
                    case("0"): sb.Append("a"); break;
                    case("1"): sb.Append("b"); break;
                    case("2"): sb.Append("c"); break;
                    case("3"): sb.Append("d"); break;
                    case("4"): sb.Append("e"); break;
                    case("5"): sb.Append("f"); break;
                    case("6"): sb.Append("g"); break;
                    case("7"): sb.Append("h"); break;
                    case("8"): sb.Append("i"); break;
                    case("9"): sb.Append("j"); break;
                    case("10"): sb.Append("k"); break;
                    case("11"): sb.Append("l"); break;
                    case("12"): sb.Append("m"); break;
                    case("13"): sb.Append("n"); break;
                    case("14"): sb.Append("o"); break;
                    case("15"): sb.Append("p"); break;
                    case("16"): sb.Append("q"); break;
                    case("17"): sb.Append("r"); break;
                    case("18"): sb.Append("s"); break;
                    case("19"): sb.Append("t"); break;
                    case("20"): sb.Append("u"); break;
                    case("21"): sb.Append("v"); break;
                    case("22"): sb.Append("w"); break;
                    case("23"): sb.Append("x"); break;
                    case("24"): sb.Append("y"); break;
                    case("25"): sb.Append("z"); break;
               }
           }
           return sb.ToString();
       }
        static string[] AlphabetToNumbers(string word)
        {
            var sb = new List<string>();
            for (int i = 0; i < word.Length; i++)
            {
                string a = word.Substring(i, 1);

                switch (a)
                {
                    case "a": sb.Add("0"); break;
                    case "b": sb.Add("1"); break;
                    case "c": sb.Add("2"); break;
                    case "d": sb.Add("3"); break;
                    case "e": sb.Add("4"); break;
                    case "f": sb.Add("5"); break;
                    case "g": sb.Add("6"); break;
                    case "h": sb.Add("7"); break;
                    case "i": sb.Add("8"); break;
                    case "j": sb.Add("9"); break;
                    case "k": sb.Add("10"); break;
                    case "l": sb.Add("11"); break;
                    case "m": sb.Add("12"); break;
                    case "n": sb.Add("13"); break;
                    case "o": sb.Add("14"); break;
                    case "p": sb.Add("15"); break;
                    case "q": sb.Add("16"); break;
                    case "r": sb.Add("17"); break;
                    case "s": sb.Add("18"); break;
                    case "t": sb.Add("19"); break;
                    case "u": sb.Add("20"); break;
                    case "v": sb.Add("21"); break;
                    case "w": sb.Add("22"); break;
                    case "x": sb.Add("23"); break;
                    case "y": sb.Add("24"); break;
                    case "z": sb.Add("25"); break;
                }
            }
            return sb.ToArray();
        }
        static void Main()
        {
            string[] userInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder finalResult = new StringBuilder();
            for (int i = 0; i < userInput.Length; i++)
            {
                finalResult.Append(NumbersToAlphabet(DecimalToBase(BaseToDecimal(AlphabetToNumbers(userInput[i]), 21), 26))).Append(' ');
            }
            Console.WriteLine(finalResult.ToString());

        }
    }
}
