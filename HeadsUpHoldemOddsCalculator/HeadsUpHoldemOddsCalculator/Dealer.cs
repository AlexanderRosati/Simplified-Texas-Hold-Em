using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;

namespace HeadsUpHoldemOddsCalculator
{
    class Dealer
    {
        private List<Card> Deck;
        private Random RNG;

        public Dealer()
        {
            RNG = new Random();

            Deck = new List<Card>();

            Card[] Cards = new Card[52];

            Cards[0].CardRank = Rank.Two;
            Cards[0].CardSuit = Suit.Spade;

            Cards[1].CardRank = Rank.Three;
            Cards[1].CardSuit = Suit.Spade;

            Cards[2].CardRank = Rank.Four;
            Cards[2].CardSuit = Suit.Spade;

            Cards[3].CardRank = Rank.Five;
            Cards[3].CardSuit = Suit.Spade;

            Cards[4].CardRank = Rank.Six;
            Cards[4].CardSuit = Suit.Spade;

            Cards[5].CardRank = Rank.Seven;
            Cards[5].CardSuit = Suit.Spade;

            Cards[6].CardRank = Rank.Eight;
            Cards[6].CardSuit = Suit.Spade;

            Cards[7].CardRank = Rank.Nine;
            Cards[7].CardSuit = Suit.Spade;

            Cards[8].CardRank = Rank.Ten;
            Cards[8].CardSuit = Suit.Spade;

            Cards[9].CardRank = Rank.Jack;
            Cards[9].CardSuit = Suit.Spade;

            Cards[10].CardRank = Rank.Queen;
            Cards[10].CardSuit = Suit.Spade;

            Cards[11].CardRank = Rank.King;
            Cards[11].CardSuit = Suit.Spade;

            Cards[12].CardRank = Rank.Ace;
            Cards[12].CardSuit = Suit.Spade;

            Cards[13].CardRank = Rank.Two;
            Cards[13].CardSuit = Suit.Club;

            Cards[14].CardRank = Rank.Three;
            Cards[14].CardSuit = Suit.Club;

            Cards[15].CardRank = Rank.Four;
            Cards[15].CardSuit = Suit.Club;

            Cards[16].CardRank = Rank.Five;
            Cards[16].CardSuit = Suit.Club;

            Cards[17].CardRank = Rank.Six;
            Cards[17].CardSuit = Suit.Club;

            Cards[18].CardRank = Rank.Seven;
            Cards[18].CardSuit = Suit.Club;

            Cards[19].CardRank = Rank.Eight;
            Cards[19].CardSuit = Suit.Club;

            Cards[20].CardRank = Rank.Nine;
            Cards[20].CardSuit = Suit.Club;

            Cards[21].CardRank = Rank.Ten;
            Cards[21].CardSuit = Suit.Club;

            Cards[22].CardRank = Rank.Jack;
            Cards[22].CardSuit = Suit.Club;

            Cards[23].CardRank = Rank.Queen;
            Cards[23].CardSuit = Suit.Club;

            Cards[24].CardRank = Rank.King;
            Cards[24].CardSuit = Suit.Club;

            Cards[25].CardRank = Rank.Ace;
            Cards[25].CardSuit = Suit.Club;

            Cards[26].CardRank = Rank.Two;
            Cards[26].CardSuit = Suit.Diamond;

            Cards[27].CardRank = Rank.Three;
            Cards[27].CardSuit = Suit.Diamond;

            Cards[28].CardRank = Rank.Four;
            Cards[28].CardSuit = Suit.Diamond;

            Cards[29].CardRank = Rank.Five;
            Cards[29].CardSuit = Suit.Diamond;

            Cards[30].CardRank = Rank.Six;
            Cards[30].CardSuit = Suit.Diamond;

            Cards[31].CardRank = Rank.Seven;
            Cards[31].CardSuit = Suit.Diamond;

            Cards[32].CardRank = Rank.Eight;
            Cards[32].CardSuit = Suit.Diamond;

            Cards[33].CardRank = Rank.Nine;
            Cards[33].CardSuit = Suit.Diamond;

            Cards[34].CardRank = Rank.Ten;
            Cards[34].CardSuit = Suit.Diamond;

            Cards[35].CardRank = Rank.Jack;
            Cards[35].CardSuit = Suit.Diamond;

            Cards[36].CardRank = Rank.Queen;
            Cards[36].CardSuit = Suit.Diamond;

            Cards[37].CardRank = Rank.King;
            Cards[37].CardSuit = Suit.Diamond;

            Cards[38].CardRank = Rank.Ace;
            Cards[38].CardSuit = Suit.Diamond;

            Cards[39].CardRank = Rank.Two;
            Cards[39].CardSuit = Suit.Heart;

            Cards[40].CardRank = Rank.Three;
            Cards[40].CardSuit = Suit.Heart;

            Cards[41].CardRank = Rank.Four;
            Cards[41].CardSuit = Suit.Heart;

            Cards[42].CardRank = Rank.Five;
            Cards[42].CardSuit = Suit.Heart;

            Cards[43].CardRank = Rank.Six;
            Cards[43].CardSuit = Suit.Heart;

            Cards[44].CardRank = Rank.Seven;
            Cards[44].CardSuit = Suit.Heart;

            Cards[45].CardRank = Rank.Eight;
            Cards[45].CardSuit = Suit.Heart;

            Cards[46].CardRank = Rank.Nine;
            Cards[46].CardSuit = Suit.Heart;

            Cards[47].CardRank = Rank.Ten;
            Cards[47].CardSuit = Suit.Heart;

            Cards[48].CardRank = Rank.Jack;
            Cards[48].CardSuit = Suit.Heart;

            Cards[49].CardRank = Rank.Queen;
            Cards[49].CardSuit = Suit.Heart;

            Cards[50].CardRank = Rank.King;
            Cards[50].CardSuit = Suit.Heart;

            Cards[51].CardRank = Rank.Ace;
            Cards[51].CardSuit = Suit.Heart;

            Deck.AddRange(Cards);
        }

        private Card Deal()
        {
            int indx = RNG.Next(Deck.Count);
            Card TmpCard = Deck.ElementAt(indx);
            Deck.RemoveAt(indx);
            return TmpCard;
        }

        public void ResetDeck()
        {
            Deck = new List<Card>();

            Card[] Cards = new Card[52];

            Cards[0].CardRank = Rank.Two;
            Cards[0].CardSuit = Suit.Spade;

            Cards[1].CardRank = Rank.Three;
            Cards[1].CardSuit = Suit.Spade;

            Cards[2].CardRank = Rank.Four;
            Cards[2].CardSuit = Suit.Spade;

            Cards[3].CardRank = Rank.Five;
            Cards[3].CardSuit = Suit.Spade;

            Cards[4].CardRank = Rank.Six;
            Cards[4].CardSuit = Suit.Spade;

            Cards[5].CardRank = Rank.Seven;
            Cards[5].CardSuit = Suit.Spade;

            Cards[6].CardRank = Rank.Eight;
            Cards[6].CardSuit = Suit.Spade;

            Cards[7].CardRank = Rank.Nine;
            Cards[7].CardSuit = Suit.Spade;

            Cards[8].CardRank = Rank.Ten;
            Cards[8].CardSuit = Suit.Spade;

            Cards[9].CardRank = Rank.Jack;
            Cards[9].CardSuit = Suit.Spade;

            Cards[10].CardRank = Rank.Queen;
            Cards[10].CardSuit = Suit.Spade;

            Cards[11].CardRank = Rank.King;
            Cards[11].CardSuit = Suit.Spade;

            Cards[12].CardRank = Rank.Ace;
            Cards[12].CardSuit = Suit.Spade;

            Cards[13].CardRank = Rank.Two;
            Cards[13].CardSuit = Suit.Club;

            Cards[14].CardRank = Rank.Three;
            Cards[14].CardSuit = Suit.Club;

            Cards[15].CardRank = Rank.Four;
            Cards[15].CardSuit = Suit.Club;

            Cards[16].CardRank = Rank.Five;
            Cards[16].CardSuit = Suit.Club;

            Cards[17].CardRank = Rank.Six;
            Cards[17].CardSuit = Suit.Club;

            Cards[18].CardRank = Rank.Seven;
            Cards[18].CardSuit = Suit.Club;

            Cards[19].CardRank = Rank.Eight;
            Cards[19].CardSuit = Suit.Club;

            Cards[20].CardRank = Rank.Nine;
            Cards[20].CardSuit = Suit.Club;

            Cards[21].CardRank = Rank.Ten;
            Cards[21].CardSuit = Suit.Club;

            Cards[22].CardRank = Rank.Jack;
            Cards[22].CardSuit = Suit.Club;

            Cards[23].CardRank = Rank.Queen;
            Cards[23].CardSuit = Suit.Club;

            Cards[24].CardRank = Rank.King;
            Cards[24].CardSuit = Suit.Club;

            Cards[25].CardRank = Rank.Ace;
            Cards[25].CardSuit = Suit.Club;

            Cards[26].CardRank = Rank.Two;
            Cards[26].CardSuit = Suit.Diamond;

            Cards[27].CardRank = Rank.Three;
            Cards[27].CardSuit = Suit.Diamond;

            Cards[28].CardRank = Rank.Four;
            Cards[28].CardSuit = Suit.Diamond;

            Cards[29].CardRank = Rank.Five;
            Cards[29].CardSuit = Suit.Diamond;

            Cards[30].CardRank = Rank.Six;
            Cards[30].CardSuit = Suit.Diamond;

            Cards[31].CardRank = Rank.Seven;
            Cards[31].CardSuit = Suit.Diamond;

            Cards[32].CardRank = Rank.Eight;
            Cards[32].CardSuit = Suit.Diamond;

            Cards[33].CardRank = Rank.Nine;
            Cards[33].CardSuit = Suit.Diamond;

            Cards[34].CardRank = Rank.Ten;
            Cards[34].CardSuit = Suit.Diamond;

            Cards[35].CardRank = Rank.Jack;
            Cards[35].CardSuit = Suit.Diamond;

            Cards[36].CardRank = Rank.Queen;
            Cards[36].CardSuit = Suit.Diamond;

            Cards[37].CardRank = Rank.King;
            Cards[37].CardSuit = Suit.Diamond;

            Cards[38].CardRank = Rank.Ace;
            Cards[38].CardSuit = Suit.Diamond;

            Cards[39].CardRank = Rank.Two;
            Cards[39].CardSuit = Suit.Heart;

            Cards[40].CardRank = Rank.Three;
            Cards[40].CardSuit = Suit.Heart;

            Cards[41].CardRank = Rank.Four;
            Cards[41].CardSuit = Suit.Heart;

            Cards[42].CardRank = Rank.Five;
            Cards[42].CardSuit = Suit.Heart;

            Cards[43].CardRank = Rank.Six;
            Cards[43].CardSuit = Suit.Heart;

            Cards[44].CardRank = Rank.Seven;
            Cards[44].CardSuit = Suit.Heart;

            Cards[45].CardRank = Rank.Eight;
            Cards[45].CardSuit = Suit.Heart;

            Cards[46].CardRank = Rank.Nine;
            Cards[46].CardSuit = Suit.Heart;

            Cards[47].CardRank = Rank.Ten;
            Cards[47].CardSuit = Suit.Heart;

            Cards[48].CardRank = Rank.Jack;
            Cards[48].CardSuit = Suit.Heart;

            Cards[49].CardRank = Rank.Queen;
            Cards[49].CardSuit = Suit.Heart;

            Cards[50].CardRank = Rank.King;
            Cards[50].CardSuit = Suit.Heart;

            Cards[51].CardRank = Rank.Ace;
            Cards[51].CardSuit = Suit.Heart;

            Deck.AddRange(Cards);
        }

        public void Deal(Player Player1, Player Player2, PokerHand SharedCards)
        {
            Player1.HoldemHand.Hand[0] = Deal();
            Player1.HoldemHand.Hand[1] = Deal();

            Player2.HoldemHand.Hand[0] = Deal();
            Player2.HoldemHand.Hand[1] = Deal();

            SharedCards.Hand[0] = Deal();
            SharedCards.Hand[1] = Deal();
            SharedCards.Hand[2] = Deal();
            SharedCards.Hand[3] = Deal();
            SharedCards.Hand[4] = Deal();
        }
    }
}
