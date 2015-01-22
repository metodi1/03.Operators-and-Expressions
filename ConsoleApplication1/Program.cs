using System;
//Write an expression that checks if given positive integer number n (n <= 100) 
//is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive
//Examples:
//n	Prime?
//1	false
//2	true
//3	true
//4	false
//9	false
//97	true
//51	false
//-3	false
//0	false

class Program
{
    static void Main()
    {
        int number;
        int n;
        
        Console.Write("Write a possitive positive integer number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            //if the number is 2 or 3 the numbers is prime.
            if (number == 3 || number == 2)
            {
                Console.WriteLine("The number is prime: True");
                return;
            }

            //else calculate is it number prime. 
            {
                for (n = 2; n < number; n++)
                {

                    bool result = number % n == 0;
                    Console.WriteLine("The number is prime: {0}", result);
                    return;

                }
            }
        }
        {
            Console.WriteLine("The number is prime: False");
        }
    }
}

