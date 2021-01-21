using System;

namespace Gin_Rummy.Domain.Services
{
    public class Card
    {
        public Constants.Suit Suit { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return GetShortName(Value, Suit);
        }

        private string GetShortName(int value, Constants.Suit suit)
        {
            string valueDisplay = "";
            if (value >= 2 && value <= 10)
            {
                valueDisplay = value.ToString();
            }
            else if (value == 11)
            {
                valueDisplay = "J";
            }
            else if (value == 12)
            {
                valueDisplay = "Q";
            }
            else if (value == 13)
            {
                valueDisplay = "K";
            }
            else if (value == 14)
            {
                valueDisplay = "A";
            }

            return valueDisplay + Enum.GetName(typeof(Constants.Suit), suit)[0];
        }
    }
}
