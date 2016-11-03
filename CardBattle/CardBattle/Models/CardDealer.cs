using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardBattle.Models
{
    public class CardDealer
    {
        private readonly Random _rand = new Random();
        private static readonly int _suitsCount = Enum.GetValues(typeof(Suit)).Length;
        private static readonly int _valueCount = Enum.GetValues(typeof(Values)).Length;

        public Card RandomCard()
        {
            int suitRandom = _rand.Next(0, _suitsCount);
            int valuesRandom = _rand.Next(0, _valueCount);

            return new Card((Values)valuesRandom, (Suit)suitRandom);
           
        }
    }
}
