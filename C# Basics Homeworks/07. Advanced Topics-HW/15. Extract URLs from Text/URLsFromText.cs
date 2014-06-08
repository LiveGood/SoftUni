using System;
using System.Collections.Generic;
using System.Linq;

/*
 *  Problem 15.	Extract URLs from Text
    Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
•	http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
•	www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com
 *  Examples:
    Input	
    The site nakov.com can be access from http://nakov.com or www.nakov.com. It has subdomains
   like mail.nakov.com and svetlin.nakov.com. Please check http://blog.nakov.com for more information.
    http://nakov.com
 *  Output
    http://nakov.com
    www.nakov.com
    http://blog.nakov.com
 */
class URLsFromText
{
    static void Main()
    {
        while (true)
        {
            string textInput = Console.ReadLine();
            textInput = textInput.Replace(". ", " ");
            List<string> wordsList = textInput.Split().ToList();
            char[] httpCheck = { 'h', 't', 't', 'p', ':', '/', '/' };
            char[] wwwCheck = { 'w', 'w', 'w', '.' };


            for (int i = 0; i < wordsList.Count; i++)
            {
                bool isLinkHTTP = true;
                bool isLinkWWW = true;
                string checkElement = wordsList[i];

                if (checkElement.Length >= httpCheck.Length && checkElement.Length >= wwwCheck.Length)
                {
                    // check if element starsts with http://
                    for (int k = 0; k < httpCheck.Length; k++)
                    {
                        if (checkElement[k] != httpCheck[k])
                        {
                            isLinkHTTP = false;
                        }
                    }

                    // checking if element starst with www.
                    for (int k = 0; k < wwwCheck.Length; k++)
                    {
                        if (checkElement[k] != wwwCheck[k])
                        {
                            isLinkWWW = false;
                        }
                    }
                }
                else
                {
                    isLinkHTTP = false;
                    isLinkWWW = false;
                }

                if (isLinkHTTP ^ isLinkWWW)
                {
                    Console.WriteLine(checkElement);
                }
            }
        }
    }
}
