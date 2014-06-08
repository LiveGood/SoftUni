using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/*
 *  Problem 16.	* Counting a Word in a Text
    Write a program that counts how many times a given word occurs in given text.
    The first line in the input holds the word. The second line of the input holds
    the text. The output should be a single integer number – the number of word
    occurrences. Matching should be case-insensitive. Note that not all matching
    substrings are words and should be counted. A word is a sequence of letters
    separated by punctuation or start / end of text. Examples:
    Input	                                                                    Output
    hi                                                                          3
    Hidden networks say “Hi” only to Hitachi devices. Hi, said Matuhi. HI!
    ----------
    SoftUni                                                                     5
    The Software University (SoftUni) trains software engineers, gives them a   
    profession and a job. Visit us at http://softuni.bg. Enjoy the 
    SoftUnification at SoftUni.BG. Contact us.Email: INFO@SOFTUNI.BG. Facebook:
    https://www.facebook.com/SoftwareUniversity. YouTube:
    http://www.youtube.com/SoftwareUniversity. Google+: 
    https://plus.google.com/+SoftuniBg/. Twitter: https://twitter.com/softunibg.
    GitHub: https://github.com/softuni
    -----                                                                       
    SoftUni                                                                     0
    Software University	
 */
class CountingWords
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Word to count: ");
            string wordToCount = Console.ReadLine().ToLower();
            Console.Write("Input text: ");
            string inputText = ReadLongString().ToLower();

            char[] seperators = { ' ', '.', ',', '@', ':', '/', '(', ')', '\r', '\n', '"', '?', '!' };
            List<string> wordsList = inputText.Split(seperators, StringSplitOptions.RemoveEmptyEntries).ToList();
            int wordsCounter = 0;

            for (int i = 0; i < wordsList.Count; i++)
            {
                string currentWord = wordsList[i];
                if (currentWord == wordToCount)
                {
                    wordsCounter++;
                }
            }
            Console.WriteLine(wordsCounter);   
        }
    }

    // The methord ReadLongString() usese Console.OpenStandardInput method to read
    //  the input text. This is needed because the maximum lenght that Console.Readline()
    //  can read is 254 characters. 
    // To read more about this method visit:  http://msdn.microsoft.com/en-us/library/5kdtbb63(v=vs.110).aspx
    public static string ReadLongString()
    {
        Stream streamText = Console.OpenStandardInput();
        // this byte array defines the maximum lenght of the string entered. 
        // in our case 500 characters are enough
        byte[] bytes = new byte[500];
        int bytesInput = streamText.Read(bytes, 0, 500);
        char[] charInput = Encoding.UTF8.GetChars(bytes, 0, bytesInput);
        string inputText = new string(charInput).ToLower();
        return inputText;
    }
}
