using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardBattle.Models
{
    class Card
    {
        public Card(Values value, Suit suit)
        {
            Suit = suit;
            Value = value;
        }

        public Suit Suit { get; set; }
        public Values Value { get; set; }

        public override string ToString()
        {
            return "I created a card " + Suit + " " + Value;
        }
    }
}
