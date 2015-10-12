using System;
class PeaceOfCake
{
    static void Main()
    {
        //    Console.Write("Please enter the value for Nominator A:");
        int a = int.Parse(Console.ReadLine());
        //     Console.Write("Please neter a value for the denominator B:");
        int b = int.Parse(Console.ReadLine());
        //     Console.Write("Please enter the value for Nominator C:");
        int c = int.Parse(Console.ReadLine());
        //     Console.Write("Please neter a value for the denominator D:");
        int d = int.Parse(Console.ReadLine());


        decimal finalDenominator = b * d;
        int firstCakeNominator = a * d;
        int secondCakeNominator = c * b;
        decimal finalNominator = 0.0M;
        decimal result;
        if (b != d)
        {
            finalDenominator = b * d;
            firstCakeNominator = a * d;
            secondCakeNominator = c * b;
            finalNominator = firstCakeNominator + secondCakeNominator;
            result = finalNominator / finalDenominator;
        }
        else
        {
            finalNominator = a + c;
            result = finalNominator / b;
        }
        if (result > 1)
        {
            Console.WriteLine("{0}", Convert.ToInt32(result));
            Console.WriteLine("{0}/{1}", Convert.ToInt32(finalNominator), Convert.ToInt32(finalDenominator));
        }
        else
        {
            Console.WriteLine("{0:N22}", result);
            Console.WriteLine("{0}/{1}", Convert.ToInt32(finalNominator), Convert.ToInt32(finalDenominator));
        }

    }
}



