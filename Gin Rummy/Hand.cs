using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace Gin_Rummy
{
    class Hand
    {
        public Queue<Card> PlayerHand { get; set; }
    }

    public static class DealHand
    {
        public static Queue<Card> CreateHandCards(Queue<Card> deck)
        {
            Queue<Card> hand = new Queue<Card>();
            for (int i = 0; i <= 9; i++)
            {
                Card dealtCard = deck.Dequeue();
                hand.Enqueue(dealtCard);
            }
            return hand;
        }
    }
}
