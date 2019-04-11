using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackUI
{
    public static class Deck
    {
        public static List<Card> Cards = new List<Card>();
        public static Random random = new Random();

        private static void Initialise()
        {
            var numbers = Enumerable.Range(0, 52).ToList();
            for(int i = 0; i < 52; i++)
            {
                int cardNumber = numbers[random.Next(0, numbers.Count)];
                int value = (cardNumber % 13) + 1;
                int suit = (cardNumber / 13) + 1;
                Cards.Add(new Card((Suit)suit, (CardValue)value));
                numbers.Remove(cardNumber);
            }
        }

        public static void Shuffle()
        {
            Cards = Cards.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public static Card Draw()
        {
            if (Cards.Count == 0) Initialise();
            var drawnCard = Cards[0];
            Cards.RemoveAt(0);
            return drawnCard;
        }
    }
}
