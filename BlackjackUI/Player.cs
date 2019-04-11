using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackUI
{
    public class Player
    {
        public Hand Hand { get; set; }
        public Hand SecondaryHand { get; set; }
        public int Bet { get; set; }
        public int Balance { get; set; } = 1000;
        public bool IsDealer = false;

        public Player(bool isDealer = false)
        {
            IsDealer = isDealer;
        }
        
        public void NewHand()
        {
            Hand = IsDealer ? new Hand(1) : new Hand(2);
        }

        public void Hit()
        {
            Hand.Draw();
        }
        
        public void DoubleDown()
        {
            Bet *= 2;
            Hit();
        }

        public void Split()
        {
            SecondaryHand.AddCard(Hand.Cards[1].Suit, Hand.Cards[1].Value);
            Hand.Cards.Remove(Hand.Cards[1]);
        }
    }
}
