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

        public List<Card> Deal(int n)
        {
            if(n > 52)
            {
                return null;
            }
            List<Card> newListOfCard = new List<Card>();
            List<Card> listAllCard = new List<Card>();
            //Add all cards into a list
            for(int i =0; i< _valueCount ; i++)
            {
                for(int j =0; j< _suitsCount; j++)
                {
                    listAllCard.Add(new Card((Values)i, (Suit)j));
                }
            }

            //add random cards into a new list and remove from all card list
            for(int i =0; i<n; i++)
            {
                int randomIndex = _rand.Next(0, listAllCard.Count);
                newListOfCard.Add(listAllCard[randomIndex]);
                listAllCard.RemoveAt(randomIndex);
            }
            return newListOfCard;
        }
    }
}
