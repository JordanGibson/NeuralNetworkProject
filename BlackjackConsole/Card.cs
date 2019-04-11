﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackConsole
{
    public class Card
    {
        public Suit Suit { get; set; }
        public CardValue Value { get; set; }

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
