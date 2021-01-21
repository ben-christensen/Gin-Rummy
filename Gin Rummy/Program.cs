using System;
using Gin_Rummy.Domain.Services;
using Gin_Rummy.Services;

namespace Gin_Rummy
{
    class Program
    {
        static void Main(string[] args)
        {
            // I would use dependency injection, normally, to create the service
            var deckService = new DeckService();

            var deck = deckService.CreateDeck();
            var andrewHand = deckService.CreateHandCards(deck, new Player
            {
                Name = "Andrew"
            });
            var benHand = deckService.CreateHandCards(deck, new Player
            {
                Name = "Ben"
            });

            Console.WriteLine($"{andrewHand.Player.Name}'s Hand:");
            foreach (var card in andrewHand.PlayerHand)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine($"{benHand.Player.Name}'s Hand:");
            foreach (var card in benHand.PlayerHand)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine("Remaining Cards:");
            foreach (var element in deck.GameDeck)
            {
                Console.WriteLine(element);
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