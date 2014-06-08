using System;
using System.Numerics;

class BinToDec
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        long inputInDec = 0;
        int powerOf = 0;

        //this method uses mathmeatic expressions
        BigInteger inputInBin = BigInteger.Parse(inputString);
        while (inputInBin > 0)
        {
            if (inputInBin % 10 == 1)
            {
                inputInDec += (long)Math.Pow(2, powerOf);
            }
            inputInBin /= 10;
            powerOf++;
        }
        Console.WriteLine(inputInDec);

        //this method uses char array wher 
        //char[] charArray = inputString.ToCharArray();
        //for (int i = charArray.Length - 1; i >= 0; i--)
        //{
        //    if (charArray[i] == '1')
        //    {
        //        inputInDec += (long)Math.Pow(2, powerOf);   
        //    }
        //    powerOf++;
        //}
        //Console.WriteLine(inputInDec);
        
    }
}
