using System;
//Write a Boolean expression that returns if the bit at position p 
//(counting from 0, starting from the right) in given integer number n, has value of 1.
//Examples:
//n 	binary representation of n	p	bit @ p == 1
//5	    00000000 00000101	        2	     true
//0	    00000000 00000000	        9	     false
//15	00000000 00001111	        1	     true
//5343	00010100 11011111	        7	     true
//62241	11110011 00100001


class Program
{
    static void Main()
    {
        //write number.
        Console.Write("Write number:");
        int number = int.Parse(Console.ReadLine());

        //write position.
        Console.Write("Write position:");
        int position = int.Parse(Console.ReadLine());

        //calculation.
        // create a mask->number where number of bits is p, all of bits are 0 exept the last one.    
        int mask = 1 << position;

        //
        int nAndMask = number & mask;

        //move the bits to the left.
        int bit = nAndMask >> position;
        
        bool result = bit == 1;

        //print result.
        Console.WriteLine("The value of the bit {0} has value of 1: {1}", position, result);
        Console.WriteLine("Binary representation");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
