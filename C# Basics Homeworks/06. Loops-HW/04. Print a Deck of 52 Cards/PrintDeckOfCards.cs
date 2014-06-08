using System;
using System.Text;

/*
 *  Problem 4.	Print a Deck of 52 Cards
 *  Write a program that generates and prints all possible cards from a standard deck of 52 cards
 *  (without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦).
 *  The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds,
 *  hearts and spades. Use 2 nested for-loops and a switch-case statement.
 */
class PrintDeckOfCards
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        char card = '0';
        char color = '0';

        for (int i = 0; i < 13; i++)
        {
            switch (i)
            {
                case 0: card = '2'; break;
                case 1: card = '3'; break;
                case 2: card = '4'; break;
                case 3: card = '5'; break;
                case 4: card = '6'; break;
                case 5: card = '7'; break;
                case 6: card = '8'; break;
                case 7: card = '9'; break;
                case 8: card = 'T'; break;
                case 9: card = 'J'; break;
                case 10: card = 'Q'; break;
                case 11: card = 'K'; break;
                case 12: card = 'A'; break;
            }
            for (int k = 0; k < 4; k++)
            {
                switch (k)
                {
                    case 0: color = (char)5; break;
                    case 1: color = (char)4; break;
                    case 2: color = (char)3; break;
                    case 3: color = (char)6; break;   
                }
                Console.Write(card + "" + color + " ");
            }
            Console.WriteLine();
        }
        // This solution uses arrays
        //char[] cardsArray = { '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A' };

        //for (int i = 0; i < cardsArray.Length; i++)
        //{
        //    for (int k = 3; k <= 6; k++)
        //    {
        //        Console.Write(cardsArray[i] + "" + (char)k + " ");
        //    }
        //    Console.WriteLine();
        //}

    }
}
