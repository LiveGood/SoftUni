using System;
/*
   Problem 16.	** Bit Exchange (Advanced)
   Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1}
   of a given 32-bit unsigned integer. The first and the second sequence of bits may not overlap. 
 */
class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("q = ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        int bitCounter = 0;
        uint nCopy = n;
        while (nCopy > 0)
        {
            nCopy /= 2;
            bitCounter++;
        }
        //Console.WriteLine(bitCounter);
         
        if (Math.Max(p, q) + k > bitCounter || p < 0 || q < 0 || k < 0)
        {
            Console.WriteLine("out of range");
            return;
        }
        else if (!(Math.Min(p, q) + k <= Math.Max(p, q)))
        {
            Console.WriteLine("overlapping");
            return;
        }
       
        nCopy = n;
        for (int i = p, ii = q; i < p + k; i++, ii++)
        {
            int mask1 = 1 << i;
            int mask2 = 1 << ii;
            n = (nCopy & (uint)mask1) == 0 ? n & ~(uint)mask2 : n | (uint)mask2;
            n = (nCopy & (uint)mask2) == 0 ? n & ~(uint)mask1 : n | (uint)mask1;
        }
        Console.WriteLine("n = " + n);
    }
}
