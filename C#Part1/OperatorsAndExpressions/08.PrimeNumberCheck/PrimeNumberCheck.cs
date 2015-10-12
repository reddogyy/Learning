/*
 Problem 8. Prime Number Check

Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
 */

using System;
class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime=true;
        if (number == 1)
        {
            isPrime = false;
            Console.WriteLine("The number {0} is prime ={1}", number, isPrime);
        }
        else
        {

            for (int i = 3; i <= number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
                if (number % 2 == 0)
                {
                    isPrime = false;
                }
                else
                {
                    isPrime = true;
                }
            }

            Console.WriteLine("This number {0} prime = {1} ",number,isPrime);
        }
    }
}

