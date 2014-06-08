using System;
/*
    Problem 15.	* Bits Exchange
    Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. 
 */
class BitsExchange
{
    static void Main()
    {
        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine());

        for (int i = 3; i < 6; i++)
        {
            int mask1 = 1 << i;   
        }
        Console.WriteLine("n after exchange = {0}", n);

    }
}
