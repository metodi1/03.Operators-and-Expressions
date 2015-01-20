using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
//Examples:
//x 	 y	     inside
//0 	 1	     true
//-2	 0	     true
//-1	 2	     false
//1.5	-1	     true
//-1.5	-1.5	 false
//100	-30	     false
//0	     0	     true
//0.2	-0.8	 true
//0.9	-1.93	 false
//1	    1.655	 true

class Program
{
    static void Main()
    {
        //write X.
        Console.Write("Write X:");
        double X = double.Parse(Console.ReadLine());

        Console.Write("Write Y:");
        double Y = double.Parse(Console.ReadLine());

        //using Pythagorean Theorem to find the distans from the center to the point.
        double hip2 = X*X + Y * Y;
        double hipotenuza = Math.Sqrt(hip2);
        
        //radius is 2,
        int radius = 2;

        //check is it hipotenuza is greater then radius.
        bool result = hipotenuza < radius;

        //Prints on the console.
        Console.WriteLine("The point is inside a circle:{0}", result);
    }
}
