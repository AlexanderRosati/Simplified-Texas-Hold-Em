using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeadsUpHoldemOddsCalculator
{
    public class Player
    {
        public HoldemHand HoldemHand;
        public Odds PlayersOdds;
        public int Money;

        public Player()
        {
            HoldemHand = new HoldemHand();
            Money = 100;
        }
    }
}