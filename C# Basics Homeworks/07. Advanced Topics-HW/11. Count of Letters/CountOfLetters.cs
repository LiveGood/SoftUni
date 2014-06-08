using System;
using System.Collections.Generic;

/*
 *  Problem 11.	Count of Letters
    Write a program that reads a list of letters and prints for each
    letter how many times it appears in the list. The letters should 
    be listed in alphabetical order. Use the input and output format 
    from the examples below. Examples:
    Input	                Output
    b b a a b	            a -> 2
                            b -> 3
    -------
    h d h a a a s d         a -> 6
    f d a d j d s h a a	    d -> 5
                            f -> 1
                            h -> 3
                            j -> 1
                            s -> 2
                            
 */
class CountOfLetters
{
    static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();
            input = input.Replace(" ", "");
            char[] charArray = input.ToCharArray();
            List<char> charList = new List<char>();

            foreach (char c in charArray)
            {
                charList.Add(c);
            }

            int lettersCount = 26;
            for (int i = 0; i < lettersCount; i++)
            {
                char letter = (char)('a' + i);
                if (charList.Contains(letter))
                {
                    int letterCounter = 0;
                    for (int k = 0; k < charList.Count; k++)
                    {
                        if (charList[k] == letter)
                        {
                            letterCounter++;
                        }
                    }
                    Console.WriteLine("{0} -> {1}", letter, letterCounter);
                }
            }   
        }
    }
}
