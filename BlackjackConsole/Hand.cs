﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackConsole
{
    class Hand
    {
        public List<Card> Cards { get; } = new List<Card>();
        public bool ContainsAce { get { return Cards.Where(x => (int)x.Value == 1).Count() != 0; } }

        public Hand(int numberOfCards)
        {
            for(int i = 0; i < numberOfCards; i++)
            {
                AddCard(Deck.Draw());
            }
        }

        public (int, int) GetHandTotal()
        {
            int min = 0, max = 0;
            min = Cards.Sum(x => { if ((int)x.Value > 10) return 10; return (int)x.Value; });
            max = min;
            max += 10 * Cards.Where(x => (int)x.Value == 1).Count();
            return (min, max);
        }

        public void Draw()
        {
            AddCard(Deck.Draw());
        }

        public override string ToString()
        {
            return Cards.Select(x => x.ToString()).Aggregate((x, y) => x + "\n" + y);
        }

        public void AddCard(Suit suit, CardValue value)
        {
            Cards.Add(new Card(suit, value));
        }

        private void AddCard(Card card)
        {
            Cards.Add(card);
        }
    }
}
