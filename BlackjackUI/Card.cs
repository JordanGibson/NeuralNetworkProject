using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackUI
{
    public class Card
    {
        public Suit Suit { get; set; }
        public CardValue Value { get; set; }
        public static Card Blank { get { return new Card(); } }
        public bool IsBlank = false;

        private Card()
        {
            IsBlank = true;
        }

        public Card(Suit suit, CardValue value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return  (int)Value + " " + Suit.ToString();
        }
    }
}
