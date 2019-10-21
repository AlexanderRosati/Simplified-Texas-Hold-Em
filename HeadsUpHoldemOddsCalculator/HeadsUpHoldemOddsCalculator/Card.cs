using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsUpHoldemOddsCalculator
{
    public struct Card : IComparable<Card>
    {
        public Rank CardRank;
        public Suit CardSuit;

        public int CompareTo(Card Other)
        {
            if (CardRank > Other.CardRank)
            {
                return -1;
            }

            else if (CardRank == Other.CardRank)
            {
                return 0;
            }

            else
            {
                return 1;
            }
        }

        public Card(Rank CardRank, Suit CardSuit)
        {
            this.CardRank = CardRank;
            this.CardSuit = CardSuit;
        }
    }
}