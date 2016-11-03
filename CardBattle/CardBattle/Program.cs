using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardBattle.Models;
using System.Diagnostics;

namespace CardBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            var spadesAce = new Card(Values.Ace, Suit.Spade);
            Console.WriteLine("I created a " + spadesAce.ToString());

            CardDealer dealer = new CardDealer();

            //for(int i =0; i<10; i++)
            //{
            //    Card randomCard = dealer.RandomCard();
            //    
            //    Console.WriteLine("I drew a "  + randomCard.ToString());
            //
            //}

            var DealtCard = dealer.Deal(52);
            DealtCard = SortCard.ShakeSort(DealtCard);
            foreach(Card card in DealtCard)
            {
                Console.WriteLine(card.ToString());
            }
            //Console.WriteLine("my hand contains" + string.Join(", ", DealtCard.Select(c => c.ToString()).ToArray()));



            Console.ReadLine();
        }
    }
}
