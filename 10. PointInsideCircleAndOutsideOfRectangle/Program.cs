using System;
//Write an expression that checks for given point (x, y) if it is 
//within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
//Examples:
//x 	y	inside K & outside of R
//1	    2	    yes
//2.5	2	    no
//0	    1       no
//2.5	1   	no
//2	    0   	no
//4	    0   	no
//2.5	1.5 	no
//2	    1.5	    yes
//1	    2.5	    yes
//-100	-100	no


class Program
{
    static void Main()
    {
        double radius=1.5;

        //write X.
        Console.Write("Write X:");
        double X = double.Parse(Console.ReadLine());

        //write Y.
        Console.Write("Write Y:");
        double Y = double.Parse(Console.ReadLine());
        
        //calculation of distance from center of the circle and point, 
        //and check is it into cirle.
        bool circle = ((Math.Pow((X - 1), 2)) + (Math.Pow((Y - 1), 2)) < Math.Pow(radius, 2));

        //check is it into rectangle.
        bool rectangle = Y > 1;
        
        //result
        bool result = circle && rectangle;

        //Prints on the console.
        Console.WriteLine("The point is inside the circle and outside the rectangle:{0}", result);
    }
}
