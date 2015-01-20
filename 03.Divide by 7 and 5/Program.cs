using System;

//Write a Boolean expression that checks for given integer if it can be divided 
//(without remainder) by 7 and 5 at the same time.
//Examples:
//n	Divided by 7 and 5?
//3	false
//0	false
//5	false
//7	false
//35	true
//140	true

class Program
{
    static void Main()
    {
        //write the number.
        Console.Write("Write the number:");
        int number = int.Parse(Console.ReadLine());

        //check it can be divided 
        //(without remainder) by 7 and 5 at the same time
        bool result = number%5==0 && number%7==0;
        
        //print the result.
        Console.WriteLine("can be divided (without remainder) by 7 and 5 at the same time:{0}",result);
    }
}


