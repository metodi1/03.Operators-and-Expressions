using System;
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to 
//hold the value v at the position p from the binary representation of n while preserving all other bits in n.
//Examples:
//n	        binary representation of n	p	    v	binary result	    result
//	        00000000 00000101	        2	    0	00000000 00000001	1
//0 	    00000000 00000000	        9	    1	00000010 00000000	512
//15    	00000000 00001111	        1	    1	00000000 00001111	15
//5343	    00010100 11011111	        7	    0	00010100 01011111	5215
//62241	    11110011 00100001	        11	    0	11110011 00100001	62241


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

        //write position.
        Console.Write("Write bit value:");
        byte bit = byte.Parse(Console.ReadLine());

        if (bit == 0)
        // Set the bit at position p to 0 in a number n  
        {            
            int mask = ~(1 << position);       
            int result = number & mask;      
            Console.WriteLine(result);
            Convert.ToString(result, 2).PadLeft(32, '0');
        }
        //set the bit at position p to 1
        {
            int mask = 1 << position;          
            int result = number | mask;      
            Console.WriteLine(result);
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));

        }
    }
}
