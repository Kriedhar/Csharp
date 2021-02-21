using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace ProgrammingAssignment2
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 2
    /// </summary>
    class Program
    {
        /// <summary>
        /// Implements Nothing Like Blackjack functionality
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {

                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare a deck variables and create a deck object
                // DON'T SHUFFLE THE DECK

                Deck deck = new Deck();

                // deal 2 cards each to 4 players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)

                Card card1P1 = deck.TakeTopCard();
                Card card1P2 = deck.TakeTopCard();
                Card card1P3 = deck.TakeTopCard();
                Card card1P4 = deck.TakeTopCard();
                Card card2P1 = deck.TakeTopCard();
                Card card2P2 = deck.TakeTopCard();
                Card card2P3 = deck.TakeTopCard();
                Card card2P4 = deck.TakeTopCard();

                // deal 1 more card to players 2 and 3

                Card card3P2 = deck.TakeTopCard();
                Card card3P3 = deck.TakeTopCard();

                // flip all the cards over

                card1P1.FlipOver();
                card1P2.FlipOver();
                card1P3.FlipOver();
                card1P4.FlipOver();
                card2P1.FlipOver();
                card2P2.FlipOver();
                card2P3.FlipOver();
                card2P4.FlipOver();
                card3P2.FlipOver();
                card3P3.FlipOver();

                // print the cards for player 1

                Console.WriteLine(card1P1.Rank + "," + card1P1.Suit);
                Console.WriteLine(card2P1.Rank + "," + card2P1.Suit);

                // print the cards for player 2

                Console.WriteLine(card1P2.Rank + "," + card1P2.Suit);
                Console.WriteLine(card2P2.Rank + "," + card2P2.Suit);
                Console.WriteLine(card3P2.Rank + "," + card3P2.Suit);

                // print the cards for player 3

                Console.WriteLine(card1P3.Rank + "," + card1P3.Suit);
                Console.WriteLine(card2P3.Rank + "," + card2P3.Suit);
                Console.WriteLine(card3P3.Rank + "," + card3P3.Suit);

                // print the cards for player 4

                Console.WriteLine(card1P4.Rank + "," + card1P4.Suit);
                Console.WriteLine(card2P4.Rank + "," + card2P4.Suit);

                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }
    }
}
