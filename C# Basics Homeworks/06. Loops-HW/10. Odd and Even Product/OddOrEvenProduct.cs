using System;
/*
 *  Problem 10.	Odd and Even Product
 *  You are given n integers (given in a single line, separated by a space). Write a program 
 *  that checks whether the product of the odd elements is equal to the product of the even 
 *  elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc. 
 */
class OddOrEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] stringArray = input.Split(' ');
        long oddProduct = 1;
        long evernProdcut = 1;

        for (int i = 0; i < stringArray.Length;  i++)
        {
            int integer = int.Parse(stringArray[i]);
            if (i % 2 == 0)
            {
                oddProduct *= integer;   
            }
            else
            {
                evernProdcut *= integer;
            }
        }

        if (oddProduct == evernProdcut)
        {
            Console.WriteLine("yes\nproduct = {0}", evernProdcut);    
        }
        else
        {
            Console.WriteLine("no\nodd_prodcut = {0}", oddProduct);
            Console.WriteLine("even_prodcut = {0}", evernProdcut);            
        }


    }
}
