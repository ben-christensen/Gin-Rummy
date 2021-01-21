using System;
using System.Collections;

namespace Gin_Rummy
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = DeckCreator.CreateCards(); //Returns a shuffled set of cards
            var p1hand = DealHand.CreateHandCards(deck);
            var p2hand = DealHand.CreateHandCards(deck);

            Console.WriteLine("Player 1 Hand:");
            foreach (var element in p1hand)
            {
                Console.WriteLine(element.DisplayName);
            }

            Console.WriteLine("Player 2 Hand:");
            foreach (var element in p2hand)
            {
                Console.WriteLine(element.DisplayName);
            }

            Console.WriteLine("Remaining Cards:");
            foreach (var element in deck)
            {
                Console.WriteLine(element.DisplayName);
            }

        }
    }
}



//Create a computer console based version of your favorite card game. 
//You’ll probably want to have classes for a player’s hand, a card, 
//the table, the deck, and a round or game.

//Your program should actually "shuffle" cards in an array before each deal 
//(sounds like another good use for System.Random). It is not necessary to print 
//graphical-looking cards on the screen. The game should support multiple players 
//and never deal the same card twice.

//Add the ability to play against one or more computer opponents. 
//Think about ways you can make the computer a more challenging opponent by 
//making it “smarter”.

//Have your program enforce the rules of the game.