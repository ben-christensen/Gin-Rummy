using System.Collections.Generic;
using Gin_Rummy.Domain.Services;

namespace Gin_Rummy.Domain
{
    public static class Extensions
    {
        public static void Enqueue(this Queue<Card> cards, Queue<Card> newCards)
        {
            foreach (var card in newCards)
            {
                cards.Enqueue(card);
            }
        }
    }
}
