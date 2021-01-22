using System;
using System.Linq;
using Gin_Rummy.Domain.Services;
using Gin_Rummy.Services;
using Xunit;

namespace GinRummy.UnitTests
{
    public class DeckServiceUnitTests
    {
        public DeckService _systemUnderTest;

        public DeckServiceUnitTests()
        {
            _systemUnderTest = new DeckService();
        }

        public class CreateDeck : DeckServiceUnitTests
        {
            [Fact]
            public void WHEN_CreateDeck_is_called_THEN_random_deck_of_cards_returned()
            {
                var actual = _systemUnderTest.CreateDeck();

                Assert.Equal(52, actual.GameDeck.Count);

                // any other asserts you want to do to make sure the deck was created correctly
            }
        }

        public class Shuffle : DeckServiceUnitTests
        {
            [Fact]
            public void GIVEN_cards_in_order_WHEN_Shuffle_is_called_THEN_cards_are_in_random_order()
            {
                var cards = _systemUnderTest.CreateDeck().GameDeck;

                var actual = _systemUnderTest.Shuffle(cards);

                // ensure the same number of cards
                Assert.Equal(cards.Count, actual.Count);

                // ensure the cards are still in the deck
                foreach (var card in actual)
                {
                    Assert.True(cards.Contains(card));
                }

                // ensure they are in a different order
                for(var i = 0; i < cards.Count; i++)
                {
                    Assert.NotEqual(cards.ToList()[i].ToString(), actual.ToList()[i].ToString());
                }
            }
        }
    }
}
