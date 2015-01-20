using System;
//Write an expression that checks for given integer if its third digit from right-to-left is 7.
//Examples:
//n	Third digit 7?
//5	false
//701	true
//9703	true
//877	false
//777877	false
//9999799	true

class Program
{
    static void Main()
    {
        //write the number.
        Console.Write("Write the number:");
        int number = int.Parse(Console.ReadLine());

        //calculation. deveted by 100 beceouse we are looking for third digit.
        //diveted by % 10 to find is it remainder is 7.
        bool result = (number / 100) % 10 == 7;

        Console.WriteLine("Is it third number is 7:{0}", result);
                        
        
        

    }
}