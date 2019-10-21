using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeadsUpHoldemOddsCalculator
{
    public class HoldemHand
    {
        public Card[] Hand;
        private List<Card> Deck;

        public HoldemHand()
        {
            Hand = new Card[2];

            Hand[0].CardRank = Rank.Ace;
            Hand[0].CardSuit = Suit.Club;

            Hand[1].CardRank = Rank.Ace;
            Hand[1].CardSuit = Suit.Spade;

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

        public PokerHand FindBestPokerHand(PokerHand SharedCards)
        {
            PokerHand[] PokerHandArray = new PokerHand[21];

            for (int k = 0; k < 21; ++k) PokerHandArray[k] = new PokerHand();

            PokerHandArray[0].Hand[0].CardRank = Hand[0].CardRank;
            PokerHandArray[0].Hand[0].CardSuit = Hand[0].CardSuit;
            PokerHandArray[0].Hand[1].CardRank = Hand[1].CardRank;
            PokerHandArray[0].Hand[1].CardSuit = Hand[1].CardSuit;
            PokerHandArray[0].Hand[2].CardRank = SharedCards.Hand[0].CardRank;
            PokerHandArray[0].Hand[2].CardSuit = SharedCards.Hand[0].CardSuit;
            PokerHandArray[0].Hand[3].CardRank = SharedCards.Hand[1].CardRank;
            PokerHandArray[0].Hand[3].CardSuit = SharedCards.Hand[1].CardSuit;
            PokerHandArray[0].Hand[4].CardRank = SharedCards.Hand[2].CardRank;
            PokerHandArray[0].Hand[4].CardSuit = SharedCards.Hand[2].CardSuit;

            PokerHandArray[1].Hand[0].CardRank = Hand[0].CardRank;
            PokerHandArray[1].Hand[0].CardSuit = Hand[0].CardSuit;
            PokerHandArray[1].Hand[1].CardRank = Hand[1].CardRank;
            PokerHandArray[1].Hand[1].CardSuit = Hand[1].CardSuit;
            PokerHandArray[1].Hand[2].CardRank = SharedCards.Hand[0].CardRank;
            PokerHandArray[1].Hand[2].CardSuit = SharedCards.Hand[0].CardSuit;
            PokerHandArray[1].Hand[3].CardRank = SharedCards.Hand[1].CardRank;
            PokerHandArray[1].Hand[3].CardSuit = SharedCards.Hand[1].CardSuit;
            PokerHandArray[1].Hand[4].CardRank = SharedCards.Hand[3].CardRank;
            PokerHandArray[1].Hand[4].CardSuit = SharedCards.Hand[3].CardSuit;

            PokerHandArray[2].Hand[0].CardRank = Hand[0].CardRank;
            PokerHandArray[2].Hand[0].CardSuit = Hand[0].CardSuit;
            PokerHandArray[2].Hand[1].CardRank = Hand[1].CardRank;
            PokerHandArray[2].Hand[1].CardSuit = Hand[1].CardSuit;
            PokerHandArray[2].Hand[2].CardRank = SharedCards.Hand[0].CardRank;
            PokerHandArray[2].Hand[2].CardSuit = SharedCards.Hand[0].CardSuit;
            PokerHandArray[2].Hand[3].CardRank = SharedCards.Hand[1].CardRank;
            PokerHandArray[2].Hand[3].CardSuit = SharedCards.Hand[1].CardSuit;
            PokerHandArray[2].Hand[4].CardRank = SharedCards.Hand[4].CardRank;
            PokerHandArray[2].Hand[4].CardSuit = SharedCards.Hand[4].CardSuit;

            PokerHandArray[3].Hand[0].CardRank = Hand[0].CardRank;
            PokerHandArray[3].Hand[0].CardSuit = Hand[0].CardSuit;
            PokerHandArray[3].Hand[1].CardRank = Hand[1].CardRank;
            PokerHandArray[3].Hand[1].CardSuit = Hand[1].CardSuit;
            PokerHandArray[3].Hand[2].CardRank = SharedCards.Hand[0].CardRank;
            PokerHandArray[3].Hand[2].CardSuit = SharedCards.Hand[0].CardSuit;
            PokerHandArray[3].Hand[3].CardRank = SharedCards.Hand[3].CardRank;
            PokerHandArray[3].Hand[3].CardSuit = SharedCards.Hand[3].CardSuit;
            PokerHandArray[3].Hand[4].CardRank = SharedCards.Hand[4].CardRank;
            PokerHandArray[3].Hand[4].CardSuit = SharedCards.Hand[4].CardSuit;

            PokerHandArray[4].Hand[0].CardRank = Hand[0].CardRank;
            PokerHandArray[4].Hand[0].CardSuit = Hand[0].CardSuit;
            PokerHandArray[4].Hand[1].CardRank = Hand[1].CardRank;
            PokerHandArray[4].Hand[1].CardSuit = Hand[1].CardSuit;
            PokerHandArray[4].Hand[2].CardRank = SharedCards.Hand[1].CardRank;
            PokerHandArray[4].Hand[2].CardSuit = SharedCards.Hand[1].CardSuit;
            PokerHandArray[4].Hand[3].CardRank = SharedCards.Hand[3].CardRank;
            PokerHandArray[4].Hand[3].CardSuit = SharedCards.Hand[3].CardSuit;
            PokerHandArray[4].Hand[4].CardRank = SharedCards.Hand[4].CardRank;
            PokerHandArray[4].Hand[4].CardSuit = SharedCards.Hand[4].CardSuit;

            PokerHandArray[5].Hand[0].CardRank = Hand[0].CardRank;
            PokerHandArray[5].Hand[0].CardSuit = Hand[0].CardSuit;
            PokerHandArray[5].Hand[1].CardRank = Hand[1].CardRank;
            PokerHandArray[5].Hand[1].CardSuit = Hand[1].CardSuit;
            PokerHandArray[5].Hand[2].CardRank = SharedCards.Hand[2].CardRank;
            PokerHandArray[5].Hand[2].CardSuit = SharedCards.Hand[2].CardSuit;
            PokerHandArray[5].Hand[3].CardRank = SharedCards.Hand[3].CardRank;
            PokerHandArray[5].Hand[3].CardSuit = SharedCards.Hand[3].CardSuit;
            PokerHandArray[5].Hand[4].CardRank = SharedCards.Hand[4].CardRank;
            PokerHandArray[5].Hand[4].CardSuit = SharedCards.Hand[4].CardSuit;

            PokerHandArray[6].Hand[0].CardRank = Hand[0].CardRank;
            PokerHandArray[6].Hand[0].CardSuit = Hand[0].CardSuit;
            PokerHandArray[6].Hand[1].CardRank = SharedCards.Hand[0].CardRank;
            PokerHandArray[6].Hand[1].CardSuit = SharedCards.Hand[0].CardSuit;
            PokerHandArray[6].Hand[2].CardRank = SharedCards.Hand[2].CardRank;
            PokerHandArray[6].Hand[2].CardSuit = SharedCards.Hand[2].CardSuit;
            PokerHandArray[6].Hand[3].CardRank = SharedCards.Hand[3].CardRank;
            PokerHandArray[6].Hand[3].CardSuit = SharedCards.Hand[3].CardSuit;
            PokerHandArray[6].Hand[4].CardRank = SharedCards.Hand[4].CardRank;
            PokerHandArray[6].Hand[4].CardSuit = SharedCards.Hand[4].CardSuit;

            PokerHandArray[7].Hand[0].CardRank = Hand[0].CardRank;
            PokerHandArray[7].Hand[0].CardSuit = Hand[0].CardSuit;
            PokerHandArray[7].Hand[1].CardRank = SharedCards.Hand[1].CardRank;
            PokerHandArray[7].Hand[1].CardSuit = SharedCards.Hand[1].CardSuit;
            PokerHandArray[7].Hand[2].CardRank = SharedCards.Hand[2].CardRank;
            PokerHandArray[7].Hand[2].CardSuit = SharedCards.Hand[2].CardSuit;
            PokerHandArray[7].Hand[3].CardRank = SharedCards.Hand[3].CardRank;
            PokerHandArray[7].Hand[3].CardSuit = SharedCards.Hand[3].CardSuit;
            PokerHandArray[7].Hand[4].CardRank = SharedCards.Hand[4].CardRank;
            PokerHandArray[7].Hand[4].CardSuit = SharedCards.Hand[4].CardSuit;

            PokerHandArray[8].Hand[0].CardRank = Hand[1].CardRank;
            PokerHandArray[8].Hand[0].CardSuit = Hand[1].CardSuit;
            PokerHandArray[8].Hand[1].CardRank = SharedCards.Hand[1].CardRank;
            PokerHandArray[8].Hand[1].CardSuit = SharedCards.Hand[1].CardSuit;
            PokerHandArray[8].Hand[2].CardRank = SharedCards.Hand[2].CardRank;
            PokerHandArray[8].Hand[2].CardSuit = SharedCards.Hand[2].CardSuit;
            PokerHandArray[8].Hand[3].CardRank = SharedCards.Hand[3].CardRank;
            PokerHandArray[8].Hand[3].CardSuit = SharedCards.Hand[3].CardSuit;
            PokerHandArray[8].Hand[4].CardRank = SharedCards.Hand[4].CardRank;
            PokerHandArray[8].Hand[4].CardSuit = SharedCards.Hand[4].CardSuit;

            PokerHandArray[9].Hand[0].CardRank = SharedCards.Hand[0].CardRank;
            PokerHandArray[9].Hand[0].CardSuit = SharedCards.Hand[0].CardSuit;
            PokerHandArray[9].Hand[1].CardRank = SharedCards.Hand[1].CardRank;
            PokerHandArray[9].Hand[1].CardSuit = SharedCards.Hand[1].CardSuit;
            PokerHandArray[9].Hand[2].CardRank = SharedCards.Hand[2].CardRank;
            PokerHandArray[9].Hand[2].CardSuit = SharedCards.Hand[2].CardSuit;
            PokerHandArray[9].Hand[3].CardRank = SharedCards.Hand[3].CardRank;
            PokerHandArray[9].Hand[3].CardSuit = SharedCards.Hand[3].CardSuit;
            PokerHandArray[9].Hand[4].CardRank = SharedCards.Hand[4].CardRank;
            PokerHandArray[9].Hand[4].CardSuit = SharedCards.Hand[4].CardSuit;

            PokerHandArray[10].Hand[0].CardRank = Hand[0].CardRank;
            PokerHandArray[10].Hand[0].CardSuit = Hand[0].CardSuit;
            PokerHandArray[10].Hand[1].CardRank = Hand[1].CardRank;
            PokerHandArray[10].Hand[1].CardSuit = Hand[1].CardSuit;
            PokerHandArray[10].Hand[2].CardRank = SharedCards.Hand[1].CardRank;
            PokerHandArray[10].Hand[2].CardSuit = SharedCards.Hand[1].CardSuit;
            PokerHandArray[10].Hand[3].CardRank = SharedCards.Hand[2].CardRank;
            PokerHandArray[10].Hand[3].CardSuit = SharedCards.Hand[2].CardSuit;
            PokerHandArray[10].Hand[4].CardRank = SharedCards.Hand[3].CardRank;
            PokerHandArray[10].Hand[4].CardSuit = SharedCards.Hand[3].CardSuit;

            PokerHandArray[11].Hand[0].CardRank = Hand[0].CardRank;
            PokerHandArray[11].Hand[0].CardSuit = Hand[0].CardSuit;
            PokerHandArray[11].Hand[1].CardRank = SharedCards.Hand[0].CardRank;
            PokerHandArray[11].Hand[1].CardSuit = SharedCards.Hand[0].CardSuit;
            PokerHandArray[11].Hand[2].CardRank = SharedCards.Hand[1].CardRank;
            PokerHandArray[11].Hand[2].CardSuit = SharedCards.Hand[1].CardSuit;
            PokerHandArray[11].Hand[3].CardRank = SharedCards.Hand[3].CardRank;
            PokerHandArray[11].Hand[3].CardSuit = SharedCards.Hand[3].CardSuit;
            PokerHandArray[11].Hand[4].CardRank = SharedCards.Hand[4].CardRank;
            PokerHandArray[11].Hand[4].CardSuit = SharedCards.Hand[4].CardSuit;

            PokerHandArray[12].Hand[0].CardRank = Hand[1].CardRank;
            PokerHandArray[12].Hand[0].CardSuit = Hand[1].CardSuit;
            PokerHandArray[12].Hand[1].CardRank = SharedCards.Hand[0].CardRank;
            PokerHandArray[12].Hand[1].CardSuit = SharedCards.Hand[0].CardSuit;
            PokerHandArray[12].Hand[2].CardRank = SharedCards.Hand[1].CardRank;
            PokerHandArray[12].Hand[2].CardSuit = SharedCards.Hand[1].CardSuit;
            PokerHandArray[12].Hand[3].CardRank = SharedCards.Hand[3].CardRank;
            PokerHandArray[12].Hand[3].CardSuit = SharedCards.Hand[3].CardSuit;
            PokerHandArray[12].Hand[4].CardRank = SharedCards.Hand[4].CardRank;
            PokerHandArray[12].Hand[4].CardSuit = SharedCards.Hand[4].CardSuit;

            PokerHandArray[13].Hand[0].CardRank = Hand[0].CardRank;
            PokerHandArray[13].Hand[0].CardSuit = Hand[0].CardSuit;
            PokerHandArray[13].Hand[1].CardRank = Hand[1].CardRank;
            PokerHandArray[13].Hand[1].CardSuit = Hand[1].CardSuit;
            PokerHandArray[13].Hand[2].CardRank = SharedCards.Hand[0].CardRank;
            PokerHandArray[13].Hand[2].CardSuit = SharedCards.Hand[0].CardSuit;
            PokerHandArray[13].Hand[3].CardRank = SharedCards.Hand[2].CardRank;
            PokerHandArray[13].Hand[3].CardSuit = SharedCards.Hand[2].CardSuit;
            PokerHandArray[13].Hand[4].CardRank = SharedCards.Hand[4].CardRank;
            PokerHandArray[13].Hand[4].CardSuit = SharedCards.Hand[4].CardSuit;

            PokerHandArray[14].Hand[0].CardRank = Hand[1].CardRank;
            PokerHandArray[14].Hand[0].CardSuit = Hand[1].CardSuit;
            PokerHandArray[14].Hand[1].CardRank = SharedCards.Hand[0].CardRank;
            PokerHandArray[14].Hand[1].CardSuit = SharedCards.Hand[0].CardSuit;
            PokerHandArray[14].Hand[2].CardRank = SharedCards.Hand[2].CardRank;
            PokerHandArray[14].Hand[2].CardSuit = SharedCards.Hand[2].CardSuit;
            PokerHandArray[14].Hand[3].CardRank = SharedCards.Hand[3].CardRank;
            PokerHandArray[14].Hand[3].CardSuit = SharedCards.Hand[3].CardSuit;
            PokerHandArray[14].Hand[4].CardRank = SharedCards.Hand[4].CardRank;
            PokerHandArray[14].Hand[4].CardSuit = SharedCards.Hand[4].CardSuit;

            PokerHandArray[15].Hand[0].CardRank = Hand[1].CardRank;
            PokerHandArray[15].Hand[0].CardSuit = Hand[1].CardSuit;
            PokerHandArray[15].Hand[1].CardRank = SharedCards.Hand[0].CardRank;
            PokerHandArray[15].Hand[1].CardSuit = SharedCards.Hand[0].CardSuit;
            PokerHandArray[15].Hand[2].CardRank = SharedCards.Hand[1].CardRank;
            PokerHandArray[15].Hand[2].CardSuit = SharedCards.Hand[1].CardSuit;
            PokerHandArray[15].Hand[3].CardRank = SharedCards.Hand[2].CardRank;
            PokerHandArray[15].Hand[3].CardSuit = SharedCards.Hand[2].CardSuit;
            PokerHandArray[15].Hand[4].CardRank = SharedCards.Hand[3].CardRank;
            PokerHandArray[15].Hand[4].CardSuit = SharedCards.Hand[3].CardSuit;

            PokerHandArray[16].Hand[0].CardRank = Hand[0].CardRank;
            PokerHandArray[16].Hand[0].CardSuit = Hand[0].CardSuit;
            PokerHandArray[16].Hand[1].CardRank = SharedCards.Hand[0].CardRank;
            PokerHandArray[16].Hand[1].CardSuit = SharedCards.Hand[0].CardSuit;
            PokerHandArray[16].Hand[2].CardRank = SharedCards.Hand[1].CardRank;
            PokerHandArray[16].Hand[2].CardSuit = SharedCards.Hand[1].CardSuit;
            PokerHandArray[16].Hand[3].CardRank = SharedCards.Hand[2].CardRank;
            PokerHandArray[16].Hand[3].CardSuit = SharedCards.Hand[2].CardSuit;
            PokerHandArray[16].Hand[4].CardRank = SharedCards.Hand[3].CardRank;
            PokerHandArray[16].Hand[4].CardSuit = SharedCards.Hand[3].CardSuit;

            PokerHandArray[17].Hand[0].CardRank = Hand[0].CardRank;
            PokerHandArray[17].Hand[0].CardSuit = Hand[0].CardSuit;
            PokerHandArray[17].Hand[1].CardRank = SharedCards.Hand[0].CardRank;
            PokerHandArray[17].Hand[1].CardSuit = SharedCards.Hand[0].CardSuit;
            PokerHandArray[17].Hand[2].CardRank = SharedCards.Hand[1].CardRank;
            PokerHandArray[17].Hand[2].CardSuit = SharedCards.Hand[1].CardSuit;
            PokerHandArray[17].Hand[3].CardRank = SharedCards.Hand[2].CardRank;
            PokerHandArray[17].Hand[3].CardSuit = SharedCards.Hand[2].CardSuit;
            PokerHandArray[17].Hand[4].CardRank = SharedCards.Hand[4].CardRank;
            PokerHandArray[17].Hand[4].CardSuit = SharedCards.Hand[4].CardSuit;

            PokerHandArray[18].Hand[0].CardRank = Hand[0].CardRank;
            PokerHandArray[18].Hand[0].CardSuit = Hand[0].CardSuit;
            PokerHandArray[18].Hand[1].CardRank = Hand[1].CardRank;
            PokerHandArray[18].Hand[1].CardSuit = Hand[1].CardSuit;
            PokerHandArray[18].Hand[2].CardRank = SharedCards.Hand[1].CardRank;
            PokerHandArray[18].Hand[2].CardSuit = SharedCards.Hand[1].CardSuit;
            PokerHandArray[18].Hand[3].CardRank = SharedCards.Hand[2].CardRank;
            PokerHandArray[18].Hand[3].CardSuit = SharedCards.Hand[2].CardSuit;
            PokerHandArray[18].Hand[4].CardRank = SharedCards.Hand[4].CardRank;
            PokerHandArray[18].Hand[4].CardSuit = SharedCards.Hand[4].CardSuit;

            PokerHandArray[19].Hand[0].CardRank = Hand[0].CardRank;
            PokerHandArray[19].Hand[0].CardSuit = Hand[0].CardSuit;
            PokerHandArray[19].Hand[1].CardRank = Hand[1].CardRank;
            PokerHandArray[19].Hand[1].CardSuit = Hand[1].CardSuit;
            PokerHandArray[19].Hand[2].CardRank = SharedCards.Hand[0].CardRank;
            PokerHandArray[19].Hand[2].CardSuit = SharedCards.Hand[0].CardSuit;
            PokerHandArray[19].Hand[3].CardRank = SharedCards.Hand[2].CardRank;
            PokerHandArray[19].Hand[3].CardSuit = SharedCards.Hand[2].CardSuit;
            PokerHandArray[19].Hand[4].CardRank = SharedCards.Hand[3].CardRank;
            PokerHandArray[19].Hand[4].CardSuit = SharedCards.Hand[3].CardSuit;

            PokerHandArray[20].Hand[0].CardRank = Hand[1].CardRank;
            PokerHandArray[20].Hand[0].CardSuit = Hand[1].CardSuit;
            PokerHandArray[20].Hand[1].CardRank = SharedCards.Hand[0].CardRank;
            PokerHandArray[20].Hand[1].CardSuit = SharedCards.Hand[0].CardSuit;
            PokerHandArray[20].Hand[2].CardRank = SharedCards.Hand[1].CardRank;
            PokerHandArray[20].Hand[2].CardSuit = SharedCards.Hand[1].CardSuit;
            PokerHandArray[20].Hand[3].CardRank = SharedCards.Hand[2].CardRank;
            PokerHandArray[20].Hand[3].CardSuit = SharedCards.Hand[2].CardSuit;
            PokerHandArray[20].Hand[4].CardRank = SharedCards.Hand[4].CardRank;
            PokerHandArray[20].Hand[4].CardSuit = SharedCards.Hand[4].CardSuit;

            int ReturnValue, i = 0, j = 1;
            bool BestHandIsFound = false;

            while(!BestHandIsFound)
            {
                ReturnValue = PokerHandArray[i].CompareTo(PokerHandArray[j]);

                if (ReturnValue == -1)
                {
                    j = 0;
                    ++i;
                    continue;
                }

                else if (ReturnValue > -1 && j == 20)
                {
                    BestHandIsFound = true;
                }

                else
                {
                    ++j;
                }               
            }

            return PokerHandArray[i];
        }

        public Odds CalculateOdds(PokerHand SharedCards)
        {
            List<HoldemHand> PossibleHandsOfOpponent = new List<HoldemHand>();
            PokerHand BestPokerHand = new PokerHand();
            PokerHand[] BestPokerHandArray = new PokerHand[990];
            int NumWins = 0, NumDraws = 0, NumLoses = 0;
            double ChancesOfWinning = 0.0, ChancesOfLosing = 0.0, ChancesOfDrawing = 0.0;
            int ResultOfComparison;

            for (int i = 0; i < 990; ++i) BestPokerHandArray[i] = new PokerHand();

            Deck.Remove(SharedCards.Hand[0]);
            Deck.Remove(SharedCards.Hand[1]);
            Deck.Remove(SharedCards.Hand[2]);
            Deck.Remove(SharedCards.Hand[3]);
            Deck.Remove(SharedCards.Hand[4]);

            Deck.Remove(Hand[0]);
            Deck.Remove(Hand[1]);

            for (int i = 0; i < 45; ++i)
            {
                for (int j = i + 1; j < 45; ++j)
                {
                    HoldemHand TmpHoldemHand = new HoldemHand();
                    TmpHoldemHand.Hand[0] = Deck.ElementAt(i);
                    TmpHoldemHand.Hand[1] = Deck.ElementAt(j);
                    PossibleHandsOfOpponent.Insert(0, TmpHoldemHand); 
                }
            }

            BestPokerHand = FindBestPokerHand(SharedCards);

            for (int i = 0; i < 990; ++i)
            {
                BestPokerHandArray[i] = PossibleHandsOfOpponent.ElementAt(i).FindBestPokerHand(SharedCards);
            }

            for (int i = 0; i < 990; ++i)
            {
                ResultOfComparison = BestPokerHand.CompareTo(BestPokerHandArray[i]);

                if (ResultOfComparison == 1)
                {
                    ++NumWins;
                }

                else if (ResultOfComparison == -1)
                {
                    ++NumLoses;
                }

                else
                {
                    ++NumDraws;
                }
            }

            Deck.Insert(0, SharedCards.Hand[0]);
            Deck.Insert(0, SharedCards.Hand[1]);
            Deck.Insert(0, SharedCards.Hand[2]);
            Deck.Insert(0, SharedCards.Hand[3]);
            Deck.Insert(0, SharedCards.Hand[4]);

            Deck.Insert(0, Hand[0]);
            Deck.Insert(0, Hand[1]);

            ChancesOfWinning = (NumWins / 990.0) * 100.0;
            ChancesOfLosing = (NumLoses / 990.0) * 100.0;
            ChancesOfDrawing = (NumDraws / 990.0) * 100.0;

            return new Odds(ChancesOfWinning, ChancesOfLosing, ChancesOfDrawing);
        }
    }
}