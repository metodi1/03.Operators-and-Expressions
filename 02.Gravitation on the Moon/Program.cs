using System;
//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
//Examples:
//weight	weight on the Moon
//86	14.62
//74.6	12.682
//53.7	9.129

class Program
{
    static void Main()
    {
        //write weight on the Earth.
        Console.Write("What is your weight on the Earth:");
        double weightEarth = double.Parse(Console.ReadLine());

        //calculation of the weight on the moon
        double weightMoon = (weightEarth * 17) / 100;

        //Print the result.
        Console.WriteLine("The weight on the moon will be:{0:F2}", weightMoon);

    }
}

