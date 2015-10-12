/*Problem 2. Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth. */

using System;


class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Gravity on the Moon");
        double moonGravity = 17.0 / 100;
        double humanWeight;
        Console.WriteLine("Please enter your weight on the Earth");
        humanWeight = Convert.ToDouble(Console.ReadLine());
        double weightOnTheMoon = (humanWeight * moonGravity);
        Console.WriteLine("Your weight on the moon is : {0}", weightOnTheMoon);

    }
}

