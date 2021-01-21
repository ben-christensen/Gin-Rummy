using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gin_Rummy.Domain;
using Gin_Rummy.Domain.Services;

namespace Gin_Rummy.Services
{
    public class DeckService
    {
        /// <summary>
        /// Creates a deck of 52 shuffled cards
        /// </summary>
        /// <returns></returns>
        public Deck CreateDeck()
        {
            Queue<Card> cards = new Queue<Card>();
            for (int i = 2; i <= 14; i++)
            {
                foreach (Constants.Suit suit in Enum.GetValues(typeof(Constants.Suit)))
                {
                    cards.Enqueue(new Card()
                    {
                        Suit = suit,
                        Value = i,
                    });
                }
            }

            var deck = new Deck
            {
                GameDeck = Shuffle(cards)
            };
            return deck;
        }

        /// <summary>
        /// Shuffles all cards in the deck
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public Queue<Card> Shuffle(Queue<Card> cards)
        {
            //Shuffle the existing cards using Fisher-Yates Modern
            List<Card> transformedCards = cards.ToList();
            Random r = new Random(DateTime.Now.Millisecond);

            for (int n = transformedCards.Count - 1; n > 0; --n)
            {
                //Step 2: Randomly pick a card which has not been shuffled
                int k = r.Next(n + 1);

                //Step 3: Swap the selected item 
                //        with the last "unselected" card in the collection
                Card temp = transformedCards[n];
                transformedCards[n] = transformedCards[k];
                transformedCards[k] = temp;
            }

            Queue<Card> shuffledCards = new Queue<Card>();
            foreach (var card in transformedCards)
            {
                shuffledCards.Enqueue(card);
            }

            return shuffledCards;
        }

        /// <summary>
        /// Creates a 10 card hand for the specified player
        /// </summary>
        /// <param name="deck"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        public Hand CreateHandCards(Deck deck, Player player)
        {
            Queue<Card> handCards = new Queue<Card>();
            for (int i = 0; i <= 9; i++)
            {
                Card dealtCard = deck.GameDeck.Dequeue();
                handCards.Enqueue(dealtCard);
            }

            var hand = new Hand
            {
                Player = player,
                PlayerHand = handCards
            };

            return hand;
        }
    }
}
