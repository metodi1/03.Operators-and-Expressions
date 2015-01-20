using System;

//Problem 1. Odd or Even Integers
//Write an expression that checks if given integer is odd or even.
//Examples:
//n	Odd?
//3	true
//2	false
//-2	false
//-1	true
//0	false

class Program
{
    static void Main()
    {
        //white number to check
        Console.Write("White number:");
        int number = int.Parse(Console.ReadLine());

        //check the number is odd.
        bool check = (number % 2) != 0;

        //print the result.
        Console.WriteLine("{0} is odd: {1}", number,check);
    }
}
