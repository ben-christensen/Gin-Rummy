using System.Collections.Generic;

namespace Gin_Rummy.Domain.Services
{
    public class Hand
    {
        public Player Player { get; set; }
        public Queue<Card> PlayerHand { get; set; }
    }
}
