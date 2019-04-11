using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackConsole
{
    class Player
    {
        public Hand Hand { get; set; }
        public Hand SecondaryHand { get; set; }

        public Player()
        {
            Hand = new Hand(2);
        }
        
        public void Hit()
        {
            Hand.Draw();
        }

        public void Stick()
        {

        }

        public void DoubleDown()
        {

        }

        public void Split()
        {

        }
    }
}
