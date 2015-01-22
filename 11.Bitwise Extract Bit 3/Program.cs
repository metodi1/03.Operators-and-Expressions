using System;
//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.
//Examples:
//n 	binary representation	bit #3
//5	    00000000 00000101	        0
//0	    00000000 00000000	        0
//15	00000000 00001111	        1
//5343	00010100 11011111	        1
//62241	11110011 00100001	        0


class Program
{
    static void Main()
    {
        //write number.
        Console.Write("Write number:");
        int number = int.Parse(Console.ReadLine());

        //bit #3
        int p = 3;
        
        //calculation.
        // create a mask->number where number of bits is p, all of bits are 0 exept the last one.    
        int mask = 1 << p; 
      
        //
        int nAndMask = number & mask;

        //move the bits to the left.
        int bit = nAndMask >> p;

        //print result.
        Console.WriteLine("The value of the bit #3 is: {0}", bit);
        Console.WriteLine("Binary representation");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}