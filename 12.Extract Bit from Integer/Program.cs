using System;
//Write an expression that extracts from given integer n the value of given bit at index p.
//Examples:
//n 	binary representation	p bit @     p
//5	    00000000 00000101	    2	        1
//0	    00000000 00000000	    9	        0
//15	00000000 00001111	    1	        1
//5343	00010100 11011111	    7       	1
//62241	11110011 00100001	    11	        0


class Program
{
    static void Main(string[] args)
    {
        //write number.
        Console.Write("Write number:");
        int number = int.Parse(Console.ReadLine());

        //write index.
        Console.Write("Write index:");
        int index = int.Parse(Console.ReadLine());      

        //calculation.
        // create a mask->number where number of bits is p, all of bits are 0 exept the last one.    
        int mask = 1 << index;

        //
        int nAndMask = number & mask;

        //move the bits to the left.
        int bit = nAndMask >> index;

        //print result.
        Console.WriteLine("The value of the bit {0} is: {1}", index,bit);
        Console.WriteLine("Binary representation");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}