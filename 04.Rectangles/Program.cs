using System;

//Write an expression that calculates rectangle’s perimeter and area by given width and height.
//Examples:
//width	height	perimeter	area
//3	       4    	14	    12
//2.5	   3	    11	    7.5
//5	       5	    20	    25
class Program
{
    static void Main()
    {
    //write the width.
    Console.Write("Write the width:");
    int width = int.Parse(Console.ReadLine());

    //write the height.
    Console.Write("Write the width:");
    int height = int.Parse(Console.ReadLine());
    
    //calculation
    int perimeter = width * 2 + height * 2;
    int area = width * height;

    //print the perimeter.
    Console.WriteLine("The perimeter is:{0}", perimeter);
    //print the perimeter.
    Console.WriteLine("The area is:{0}", area);
    }
}

