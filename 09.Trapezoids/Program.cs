using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.
//Examples:
//a	    b       h	    area
//5	    7	    12	    72
//2	    1	    33	    49.5
//8.5	4.3	    2.7	    17.28
//100	200	    300	    45000
//0.222	0.333	0.555	0.1540125


class Program
{
    static void Main()
    {
        Console.Write("Write a: ");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Write b: ");
        double b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Write h: ");
        double h = Convert.ToInt32(Console.ReadLine());

        //calculation of area.
        double area = ((a + b) * h) / 2;

        //print the area.
        Console.WriteLine("The area is:{0}",area);
    }
}
