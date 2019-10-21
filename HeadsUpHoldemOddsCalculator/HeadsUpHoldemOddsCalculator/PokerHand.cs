using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsUpHoldemOddsCalculator
{
    public class PokerHand : IComparable<PokerHand>
    {
        public Card[] Hand;

        public PokerHand()
        {
            Hand = new Card[5];

            Hand[0].CardRank = Rank.Two;
            Hand[0].CardSuit = Suit.Club;

            Hand[1].CardRank = Rank.Three;
            Hand[1].CardSuit = Suit.Club;

            Hand[2].CardRank = Rank.Four;
            Hand[2].CardSuit = Suit.Club;

            Hand[3].CardRank = Rank.Five;
            Hand[3].CardSuit = Suit.Club;

            Hand[4].CardRank = Rank.Six;
            Hand[4].CardSuit = Suit.Club;
        }

        private int NumberOfRank(Rank Rank)
        {
            int numOfRank = 0;

            for (int i = 0; i < 5; ++i)
            {
                if (Hand[i].CardRank == Rank)
                {
                    ++numOfRank;
                }
            }

            return numOfRank;
        }

        public bool IsOnePair()
        {
            bool IsOnePair;

            int NumTwos = NumberOfRank(Rank.Two);
            int NumThrees = NumberOfRank(Rank.Three);
            int NumFours = NumberOfRank(Rank.Four);
            int NumFives = NumberOfRank(Rank.Five);
            int NumSixes = NumberOfRank(Rank.Six);
            int NumSevens = NumberOfRank(Rank.Seven);
            int NumEights = NumberOfRank(Rank.Eight);
            int NumNines = NumberOfRank(Rank.Nine);
            int NumTens = NumberOfRank(Rank.Ten);
            int NumJacks = NumberOfRank(Rank.Jack);
            int NumQueens = NumberOfRank(Rank.Queen);
            int NumKings = NumberOfRank(Rank.King);
            int NumAces = NumberOfRank(Rank.Ace);

            List<int> ListToTestForOnePair = new List<int>();
            List<int> ListToCompareTo = new List<int>();

            if (NumTwos != 0) ListToTestForOnePair.Add(NumTwos);
            if (NumThrees != 0) ListToTestForOnePair.Add(NumThrees);
            if (NumFours != 0) ListToTestForOnePair.Add(NumFours);
            if (NumFives != 0) ListToTestForOnePair.Add(NumFives);
            if (NumSixes != 0) ListToTestForOnePair.Add(NumSixes);
            if (NumSevens != 0) ListToTestForOnePair.Add(NumSevens);
            if (NumEights != 0) ListToTestForOnePair.Add(NumEights);
            if (NumNines != 0) ListToTestForOnePair.Add(NumNines);
            if (NumTens != 0) ListToTestForOnePair.Add(NumTens);
            if (NumJacks != 0) ListToTestForOnePair.Add(NumJacks);
            if (NumQueens != 0) ListToTestForOnePair.Add(NumQueens);
            if (NumKings != 0) ListToTestForOnePair.Add(NumKings);
            if (NumAces != 0) ListToTestForOnePair.Add(NumAces);

            ListToCompareTo.Add(1);
            ListToCompareTo.Add(1);
            ListToCompareTo.Add(1);
            ListToCompareTo.Add(2);

            ListToTestForOnePair.Sort();
            ListToCompareTo.Sort();

            if ((ListToCompareTo[0] == ListToTestForOnePair[0]) &&
                (ListToCompareTo[1] == ListToTestForOnePair[1]) &&
                (ListToCompareTo[2] == ListToTestForOnePair[2]) &&
                (ListToCompareTo[3] == ListToTestForOnePair[3]))
            {
                IsOnePair = true;   
            }

            else
            {
                IsOnePair = false;
            }

            return IsOnePair;
        }

        public bool IsTwoPair()
        {
            bool IsTwoPair;

            int NumTwos = NumberOfRank(Rank.Two);
            int NumThrees = NumberOfRank(Rank.Three);
            int NumFours = NumberOfRank(Rank.Four);
            int NumFives = NumberOfRank(Rank.Five);
            int NumSixes = NumberOfRank(Rank.Six);
            int NumSevens = NumberOfRank(Rank.Seven);
            int NumEights = NumberOfRank(Rank.Eight);
            int NumNines = NumberOfRank(Rank.Nine);
            int NumTens = NumberOfRank(Rank.Ten);
            int NumJacks = NumberOfRank(Rank.Jack);
            int NumQueens = NumberOfRank(Rank.Queen);
            int NumKings = NumberOfRank(Rank.King);
            int NumAces = NumberOfRank(Rank.Ace);

            List<int> ListToTestForTwoPair = new List<int>();
            List<int> ListToCompareTo = new List<int>();

            if (NumTwos != 0) ListToTestForTwoPair.Add(NumTwos);
            if (NumThrees != 0) ListToTestForTwoPair.Add(NumThrees);
            if (NumFours != 0) ListToTestForTwoPair.Add(NumFours);
            if (NumFives != 0) ListToTestForTwoPair.Add(NumFives);
            if (NumSixes != 0) ListToTestForTwoPair.Add(NumSixes);
            if (NumSevens != 0) ListToTestForTwoPair.Add(NumSevens);
            if (NumEights != 0) ListToTestForTwoPair.Add(NumEights);
            if (NumNines != 0) ListToTestForTwoPair.Add(NumNines);
            if (NumTens != 0) ListToTestForTwoPair.Add(NumTens);
            if (NumJacks != 0) ListToTestForTwoPair.Add(NumJacks);
            if (NumQueens != 0) ListToTestForTwoPair.Add(NumQueens);
            if (NumKings != 0) ListToTestForTwoPair.Add(NumKings);
            if (NumAces != 0) ListToTestForTwoPair.Add(NumAces);

            ListToCompareTo.Add(1);
            ListToCompareTo.Add(2);
            ListToCompareTo.Add(2);

            ListToTestForTwoPair.Sort();
            ListToCompareTo.Sort();

            if ((ListToCompareTo[0] == ListToTestForTwoPair[0]) &&
                (ListToCompareTo[1] == ListToTestForTwoPair[1]) &&
                (ListToCompareTo[2] == ListToTestForTwoPair[2]))
            {
                IsTwoPair = true;
            }

            else
            {
                IsTwoPair = false;
            }

            return IsTwoPair;
        }

        public bool IsThreeOfAKind()
        {
            bool IsThreeOfAKind;

            int NumTwos = NumberOfRank(Rank.Two);
            int NumThrees = NumberOfRank(Rank.Three);
            int NumFours = NumberOfRank(Rank.Four);
            int NumFives = NumberOfRank(Rank.Five);
            int NumSixes = NumberOfRank(Rank.Six);
            int NumSevens = NumberOfRank(Rank.Seven);
            int NumEights = NumberOfRank(Rank.Eight);
            int NumNines = NumberOfRank(Rank.Nine);
            int NumTens = NumberOfRank(Rank.Ten);
            int NumJacks = NumberOfRank(Rank.Jack);
            int NumQueens = NumberOfRank(Rank.Queen);
            int NumKings = NumberOfRank(Rank.King);
            int NumAces = NumberOfRank(Rank.Ace);

            List<int> ListToTestForThreeOfAKind = new List<int>();
            List<int> ListToCompareTo = new List<int>();

            if (NumTwos != 0) ListToTestForThreeOfAKind.Add(NumTwos);
            if (NumThrees != 0) ListToTestForThreeOfAKind.Add(NumThrees);
            if (NumFours != 0) ListToTestForThreeOfAKind.Add(NumFours);
            if (NumFives != 0) ListToTestForThreeOfAKind.Add(NumFives);
            if (NumSixes != 0) ListToTestForThreeOfAKind.Add(NumSixes);
            if (NumSevens != 0) ListToTestForThreeOfAKind.Add(NumSevens);
            if (NumEights != 0) ListToTestForThreeOfAKind.Add(NumEights);
            if (NumNines != 0) ListToTestForThreeOfAKind.Add(NumNines);
            if (NumTens != 0) ListToTestForThreeOfAKind.Add(NumTens);
            if (NumJacks != 0) ListToTestForThreeOfAKind.Add(NumJacks);
            if (NumQueens != 0) ListToTestForThreeOfAKind.Add(NumQueens);
            if (NumKings != 0) ListToTestForThreeOfAKind.Add(NumKings);
            if (NumAces != 0) ListToTestForThreeOfAKind.Add(NumAces);

            ListToCompareTo.Add(1);
            ListToCompareTo.Add(1);
            ListToCompareTo.Add(3);

            ListToTestForThreeOfAKind.Sort();
            ListToCompareTo.Sort();

            if ((ListToCompareTo[0] == ListToTestForThreeOfAKind[0]) &&
                (ListToCompareTo[1] == ListToTestForThreeOfAKind[1]) &&
                (ListToCompareTo[2] == ListToTestForThreeOfAKind[2]))
            {
                IsThreeOfAKind = true;
            }

            else
            {
                IsThreeOfAKind = false;
            }

            return IsThreeOfAKind;
        }

        public bool IsStraight()
        {
            //Assumption: No Wrap Around
            int NumTwos = NumberOfRank(Rank.Two);
            int NumThrees = NumberOfRank(Rank.Three);
            int NumFours = NumberOfRank(Rank.Four);
            int NumFives = NumberOfRank(Rank.Five);
            int NumSixes = NumberOfRank(Rank.Six);
            int NumSevens = NumberOfRank(Rank.Seven);
            int NumEights = NumberOfRank(Rank.Eight);
            int NumNines = NumberOfRank(Rank.Nine);
            int NumTens = NumberOfRank(Rank.Ten);
            int NumJacks = NumberOfRank(Rank.Jack);
            int NumQueens = NumberOfRank(Rank.Queen);
            int NumKings = NumberOfRank(Rank.King);
            int NumAces = NumberOfRank(Rank.Ace);

            if ((NumTwos == 1) && (NumThrees == 1) && (NumFours == 1) && (NumFives == 1) &&
                (NumSixes == 1))
            {
                return true;
            }

            if ((NumThrees == 1) && (NumFours == 1) && (NumFives == 1) && (NumSixes == 1) &&
                (NumSevens == 1))
            {
                return true;
            }

            if ((NumFours == 1) && (NumFives == 1) && (NumSixes == 1) && (NumSevens == 1) &&
                (NumEights == 1))
            {
                return true;
            }

            if ((NumFives == 1) && (NumSixes == 1) && (NumSevens == 1) && (NumEights == 1) &&
                (NumNines == 1))
            {
                return true;
            }

            if ((NumSixes == 1) && (NumSevens == 1) && (NumEights == 1) && (NumNines == 1) &&
                (NumTens == 1))
            {
                return true;
            }

            if ((NumSevens == 1) && (NumEights == 1) && (NumNines == 1) && (NumTens == 1) &&
                (NumJacks == 1))
            {
                return true;
            }

            if ((NumEights == 1) && (NumNines == 1) && (NumTens == 1) && (NumJacks == 1) &&
                (NumQueens == 1))
            {
                return true;
            }

            if ((NumNines == 1) && (NumTens == 1) && (NumJacks == 1) && (NumQueens == 1) &&
                (NumKings == 1))
            {
                return true;
            }

            if ((NumTens == 1) && (NumJacks == 1) && (NumQueens == 1) && (NumKings == 1) &&
                (NumAces == 1))
            {
                return true;
            }

            return false;
        }

        public bool IsFlush()
        {
            Suit FirstCardSuit = Hand[0].CardSuit;
            Suit SecondCardSuit = Hand[1].CardSuit;
            Suit ThirdCardSuit = Hand[2].CardSuit;
            Suit FourthCardSuit = Hand[3].CardSuit;
            Suit FifthCardSuit = Hand[4].CardSuit;

            if((FirstCardSuit == SecondCardSuit) && (FirstCardSuit == ThirdCardSuit) &&
                (FirstCardSuit == FourthCardSuit) && (FirstCardSuit == FifthCardSuit))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool IsFullHouse()
        {
            bool IsFullHouse;

            int NumTwos = NumberOfRank(Rank.Two);
            int NumThrees = NumberOfRank(Rank.Three);
            int NumFours = NumberOfRank(Rank.Four);
            int NumFives = NumberOfRank(Rank.Five);
            int NumSixes = NumberOfRank(Rank.Six);
            int NumSevens = NumberOfRank(Rank.Seven);
            int NumEights = NumberOfRank(Rank.Eight);
            int NumNines = NumberOfRank(Rank.Nine);
            int NumTens = NumberOfRank(Rank.Ten);
            int NumJacks = NumberOfRank(Rank.Jack);
            int NumQueens = NumberOfRank(Rank.Queen);
            int NumKings = NumberOfRank(Rank.King);
            int NumAces = NumberOfRank(Rank.Ace);

            List<int> ListToTestForFullHouse = new List<int>();
            List<int> ListToCompareTo = new List<int>();

            if (NumTwos != 0) ListToTestForFullHouse.Add(NumTwos);
            if (NumThrees != 0) ListToTestForFullHouse.Add(NumThrees);
            if (NumFours != 0) ListToTestForFullHouse.Add(NumFours);
            if (NumFives != 0) ListToTestForFullHouse.Add(NumFives);
            if (NumSixes != 0) ListToTestForFullHouse.Add(NumSixes);
            if (NumSevens != 0) ListToTestForFullHouse.Add(NumSevens);
            if (NumEights != 0) ListToTestForFullHouse.Add(NumEights);
            if (NumNines != 0) ListToTestForFullHouse.Add(NumNines);
            if (NumTens != 0) ListToTestForFullHouse.Add(NumTens);
            if (NumJacks != 0) ListToTestForFullHouse.Add(NumJacks);
            if (NumQueens != 0) ListToTestForFullHouse.Add(NumQueens);
            if (NumKings != 0) ListToTestForFullHouse.Add(NumKings);
            if (NumAces != 0) ListToTestForFullHouse.Add(NumAces);

            ListToCompareTo.Add(2);
            ListToCompareTo.Add(3);

            ListToTestForFullHouse.Sort();
            ListToCompareTo.Sort();

            if ((ListToCompareTo[0] == ListToTestForFullHouse[0]) &&
                (ListToCompareTo[1] == ListToTestForFullHouse[1]))
            {
                IsFullHouse = true;
            }

            else
            {
                IsFullHouse = false;
            }

            return IsFullHouse;
        }

        public bool IsFourOfAKind()
        {
            bool IsFourOfAKind;

            int NumTwos = NumberOfRank(Rank.Two);
            int NumThrees = NumberOfRank(Rank.Three);
            int NumFours = NumberOfRank(Rank.Four);
            int NumFives = NumberOfRank(Rank.Five);
            int NumSixes = NumberOfRank(Rank.Six);
            int NumSevens = NumberOfRank(Rank.Seven);
            int NumEights = NumberOfRank(Rank.Eight);
            int NumNines = NumberOfRank(Rank.Nine);
            int NumTens = NumberOfRank(Rank.Ten);
            int NumJacks = NumberOfRank(Rank.Jack);
            int NumQueens = NumberOfRank(Rank.Queen);
            int NumKings = NumberOfRank(Rank.King);
            int NumAces = NumberOfRank(Rank.Ace);

            List<int> ListToTestForFourOfAKind = new List<int>();
            List<int> ListToCompareTo = new List<int>();

            if (NumTwos != 0) ListToTestForFourOfAKind.Add(NumTwos);
            if (NumThrees != 0) ListToTestForFourOfAKind.Add(NumThrees);
            if (NumFours != 0) ListToTestForFourOfAKind.Add(NumFours);
            if (NumFives != 0) ListToTestForFourOfAKind.Add(NumFives);
            if (NumSixes != 0) ListToTestForFourOfAKind.Add(NumSixes);
            if (NumSevens != 0) ListToTestForFourOfAKind.Add(NumSevens);
            if (NumEights != 0) ListToTestForFourOfAKind.Add(NumEights);
            if (NumNines != 0) ListToTestForFourOfAKind.Add(NumNines);
            if (NumTens != 0) ListToTestForFourOfAKind.Add(NumTens);
            if (NumJacks != 0) ListToTestForFourOfAKind.Add(NumJacks);
            if (NumQueens != 0) ListToTestForFourOfAKind.Add(NumQueens);
            if (NumKings != 0) ListToTestForFourOfAKind.Add(NumKings);
            if (NumAces != 0) ListToTestForFourOfAKind.Add(NumAces);

            ListToCompareTo.Add(1);
            ListToCompareTo.Add(4);

            ListToTestForFourOfAKind.Sort();
            ListToCompareTo.Sort();

            if ((ListToCompareTo[0] == ListToTestForFourOfAKind[0]) &&
                (ListToCompareTo[1] == ListToTestForFourOfAKind[1]))
            {
                IsFourOfAKind = true;
            }

            else
            {
                IsFourOfAKind = false;
            }

            return IsFourOfAKind;
        }

        public bool IsStraightFlush()
        {
            if (IsFlush() && IsStraight())
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private int TieBreakerHighCardOrFlush(PokerHand HandToCompareTo)
        {
            List<Card> HandList = new List<Card>();
            List<Card> HandToCompareToList = new List<Card>();

            HandList.AddRange(Hand);
            HandToCompareToList.AddRange(HandToCompareTo.Hand);

            HandList.Sort();
            HandToCompareToList.Sort();

            if (HandList.ElementAt(0).CardRank != HandToCompareToList.ElementAt(0).CardRank)
            {
                if (HandList.ElementAt(0).CardRank > HandToCompareToList.ElementAt(0).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else if (HandList.ElementAt(1).CardRank != HandToCompareToList.ElementAt(1).CardRank)
            {
                if (HandList.ElementAt(1).CardRank > HandToCompareToList.ElementAt(1).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else if (HandList.ElementAt(2).CardRank != HandToCompareToList.ElementAt(2).CardRank)
            {
                if (HandList.ElementAt(2).CardRank > HandToCompareToList.ElementAt(2).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else if (HandList.ElementAt(3).CardRank != HandToCompareToList.ElementAt(3).CardRank)
            {
                if (HandList.ElementAt(3).CardRank > HandToCompareToList.ElementAt(3).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else if (HandList.ElementAt(4).CardRank != HandToCompareToList.ElementAt(4).CardRank)
            {
                if (HandList.ElementAt(4).CardRank > HandToCompareToList.ElementAt(4).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else
            {
                return 0;
            }
        }

        private int TieBreakerStraightOrStraighFlush(PokerHand HandToCompareTo)
        {
            List<Card> HandList = new List<Card>();
            List<Card> HandToCompareToList = new List<Card>();

            HandList.AddRange(Hand);
            HandToCompareToList.AddRange(HandToCompareTo.Hand);

            HandList.Sort();
            HandToCompareToList.Sort();

            if (HandList.ElementAt(0).CardRank != HandToCompareToList.ElementAt(0).CardRank)
            {
                if (HandList.ElementAt(0).CardRank > HandToCompareToList.ElementAt(0).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else
            {
                return 0;
            }
        }
    
        private int TieBreakerOnePair(PokerHand HandToCompareTo)
        {
            List<Card> HandList = new List<Card>();
            List<Card> HandToCompareToList = new List<Card>();

            Card TmpCard1 = new Card();
            Card TmpCard2 = new Card();

            HandList.AddRange(Hand);
            HandToCompareToList.AddRange(HandToCompareTo.Hand);

            HandList.Sort();
            HandToCompareToList.Sort();

            int i = 0;

            for (i = 0; i < 4; ++i)
            {
                if (HandList.ElementAt(i).CardRank == HandList.ElementAt(i + 1).CardRank)
                {
                    break;
                }
            }

            TmpCard1.CardRank = HandList.ElementAt(i).CardRank;
            TmpCard1.CardSuit = HandList.ElementAt(i).CardSuit;

            TmpCard2.CardRank = HandList.ElementAt(i + 1).CardRank;
            TmpCard2.CardSuit = HandList.ElementAt(i + 1).CardSuit;

            HandList.RemoveAt(i + 1);
            HandList.RemoveAt(i);

            HandList.Insert(0, TmpCard1);
            HandList.Insert(0, TmpCard2);

            for (i = 0; i < 4; ++i)
            {
                if (HandToCompareToList.ElementAt(i).CardRank == HandToCompareToList.ElementAt(i + 1).CardRank)
                {
                    break;
                }
            }

            TmpCard1.CardRank = HandToCompareToList.ElementAt(i).CardRank;
            TmpCard1.CardSuit = HandToCompareToList.ElementAt(i).CardSuit;

            TmpCard2.CardRank = HandToCompareToList.ElementAt(i + 1).CardRank;
            TmpCard2.CardSuit = HandToCompareToList.ElementAt(i + 1).CardSuit;

            HandToCompareToList.RemoveAt(i + 1);
            HandToCompareToList.RemoveAt(i);

            HandToCompareToList.Insert(0, TmpCard1);
            HandToCompareToList.Insert(0, TmpCard2);

            if (HandList.ElementAt(0).CardRank != HandToCompareToList.ElementAt(0).CardRank)
            {
                if (HandList.ElementAt(0).CardRank > HandToCompareToList.ElementAt(0).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else if (HandList.ElementAt(2).CardRank != HandToCompareToList.ElementAt(2).CardRank)
            {
                if (HandList.ElementAt(2).CardRank > HandToCompareToList.ElementAt(2).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else if (HandList.ElementAt(3).CardRank != HandToCompareToList.ElementAt(3).CardRank)
            {
                if (HandList.ElementAt(3).CardRank > HandToCompareToList.ElementAt(3).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else if (HandList.ElementAt(4).CardRank != HandToCompareToList.ElementAt(4).CardRank)
            {
                if (HandList.ElementAt(4).CardRank > HandToCompareToList.ElementAt(4).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else
            {
                return 0;
            } 

        }

        private int TieBreakerThreeOfAKind(PokerHand HandToCompareTo)
        {
            List<Card> HandList = new List<Card>();
            List<Card> HandToCompareToList = new List<Card>();
            Card TmpCard = new Card();
            Rank Rank1, Rank2, Rank3;

            HandList.AddRange(Hand);
            HandList.Sort();

            int i = 0;
            for (; i < 3; ++i)
            {
                Rank1 = HandList.ElementAt(i).CardRank;
                Rank2 = HandList.ElementAt(i + 1).CardRank;
                Rank3 = HandList.ElementAt(i + 2).CardRank;

                if ((Rank1 == Rank2) && (Rank1 == Rank3))
                {
                    break;
                }
            }

            TmpCard.CardRank = HandList.ElementAt(i).CardRank;
            TmpCard.CardSuit = HandList.ElementAt(i).CardSuit;

            HandList.RemoveAt(i + 2);
            HandList.RemoveAt(i + 1);
            HandList.RemoveAt(i);

            HandList.Insert(0, TmpCard);

            HandToCompareToList.AddRange(HandToCompareTo.Hand);
            HandToCompareToList.Sort();

            for (i = 0; i < 3; ++i)
            {
                Rank1 = HandToCompareToList.ElementAt(i).CardRank;
                Rank2 = HandToCompareToList.ElementAt(i + 1).CardRank;
                Rank3 = HandToCompareToList.ElementAt(i + 2).CardRank;

                if ((Rank1 == Rank2) && (Rank1 == Rank3))
                {
                    break;
                }
            }

            TmpCard.CardRank = HandToCompareToList.ElementAt(i).CardRank;
            TmpCard.CardSuit = HandToCompareToList.ElementAt(i).CardSuit;

            HandToCompareToList.RemoveAt(i + 2);
            HandToCompareToList.RemoveAt(i + 1);
            HandToCompareToList.RemoveAt(i);

            HandToCompareToList.Insert(0, TmpCard);

            if (HandList.ElementAt(0).CardRank != HandToCompareToList.ElementAt(0).CardRank)
            {
                if (HandList.ElementAt(0).CardRank > HandToCompareToList.ElementAt(0).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else if (HandList.ElementAt(1).CardRank != HandToCompareToList.ElementAt(1).CardRank)
            {
                if (HandList.ElementAt(1).CardRank > HandToCompareToList.ElementAt(1).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else if (HandList.ElementAt(2).CardRank != HandToCompareToList.ElementAt(2).CardRank)
            {
                if (HandList.ElementAt(2).CardRank > HandToCompareToList.ElementAt(2).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else
            {
                return 0;
            }
        }

        private int TieBreakerFourOfAKind(PokerHand HandToCompareTo)
        {
            List<Card> HandList = new List<Card>();
            List<Card> HandToCompareToList = new List<Card>();
            Rank Rank1, Rank2, Rank3, Rank4;
            Card TmpCard = new Card();

            HandList.AddRange(Hand);
            HandToCompareToList.AddRange(HandToCompareTo.Hand);

            HandList.Sort();
            HandToCompareToList.Sort();

            int i = 0;
            for(; i < 2; ++i)
            {
                Rank1 = HandList.ElementAt(i).CardRank;
                Rank2 = HandList.ElementAt(i + 1).CardRank;
                Rank3 = HandList.ElementAt(i + 2).CardRank;
                Rank4 = HandList.ElementAt(i + 3).CardRank;

                if ((Rank1 == Rank2) && (Rank1 == Rank3) && (Rank1 == Rank4))
                {
                    break;
                }
            }

            TmpCard.CardRank = HandList.ElementAt(i).CardRank;
            TmpCard.CardSuit = HandList.ElementAt(i).CardSuit;

            HandList.RemoveAt(i + 3);
            HandList.RemoveAt(i + 2);
            HandList.RemoveAt(i + 1);
            HandList.RemoveAt(i);

            HandList.Insert(0, TmpCard);

            for (i = 0; i < 2; ++i)
            {
                Rank1 = HandToCompareToList.ElementAt(i).CardRank;
                Rank2 = HandToCompareToList.ElementAt(i + 1).CardRank;
                Rank3 = HandToCompareToList.ElementAt(i + 2).CardRank;
                Rank4 = HandToCompareToList.ElementAt(i + 3).CardRank;

                if ((Rank1 == Rank2) && (Rank1 == Rank3) && (Rank1 == Rank4))
                {
                    break;
                }
            }

            TmpCard.CardRank = HandToCompareToList.ElementAt(i).CardRank;
            TmpCard.CardSuit = HandToCompareToList.ElementAt(i).CardSuit;

            HandToCompareToList.RemoveAt(i + 3);
            HandToCompareToList.RemoveAt(i + 2);
            HandToCompareToList.RemoveAt(i + 1);
            HandToCompareToList.RemoveAt(i);

            HandToCompareToList.Insert(0, TmpCard);

            if (HandList.ElementAt(0).CardRank != HandToCompareToList.ElementAt(0).CardRank)
            {
                if (HandList.ElementAt(0).CardRank > HandToCompareToList.ElementAt(0).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else if (HandList.ElementAt(1).CardRank != HandToCompareToList.ElementAt(1).CardRank)
            {
                if (HandList.ElementAt(1).CardRank > HandToCompareToList.ElementAt(1).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else
            {
                return 0;
            }
        }

        private int TieBreakerFullHouse(PokerHand HandToCompareTo)
        {
            List<Card> HandList = new List<Card>();
            List<Card> HandToCompareToList = new List<Card>();
            Card TmpCard = new Card();
            Rank Rank1, Rank2, Rank3;

            HandList.AddRange(Hand);
            HandToCompareToList.AddRange(HandToCompareTo.Hand);

            HandList.Sort();
            HandToCompareToList.Sort();

            int i = 0;
            for(; i < 3; ++i)
            {
                Rank1 = HandList.ElementAt(i).CardRank;
                Rank2 = HandList.ElementAt(i + 1).CardRank;
                Rank3 = HandList.ElementAt(i + 2).CardRank;

                if ((Rank1 == Rank2) && (Rank1 == Rank3))
                {
                    break;
                }
            }

            TmpCard.CardRank = HandList.ElementAt(i).CardRank;
            TmpCard.CardSuit = HandList.ElementAt(i).CardSuit;

            HandList.RemoveAt(i + 2);
            HandList.RemoveAt(i + 1);
            HandList.RemoveAt(i);
            HandList.RemoveAt(1);

            HandList.Insert(0, TmpCard);

            for (i = 0; i < 3; ++i)
            {
                Rank1 = HandToCompareToList.ElementAt(i).CardRank;
                Rank2 = HandToCompareToList.ElementAt(i + 1).CardRank;
                Rank3 = HandToCompareToList.ElementAt(i + 2).CardRank;

                if ((Rank1 == Rank2) && (Rank1 == Rank3))
                {
                    break;
                }
            }

            TmpCard.CardRank = HandToCompareToList.ElementAt(i).CardRank;
            TmpCard.CardSuit = HandToCompareToList.ElementAt(i).CardSuit;

            HandToCompareToList.RemoveAt(i + 2);
            HandToCompareToList.RemoveAt(i + 1);
            HandToCompareToList.RemoveAt(i);
            HandToCompareToList.RemoveAt(1);

            HandToCompareToList.Insert(0, TmpCard); 

            if (HandList.ElementAt(0).CardRank != HandToCompareToList.ElementAt(0).CardRank)
            {
                if (HandList.ElementAt(0).CardRank > HandToCompareToList.ElementAt(0).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else if (HandList.ElementAt(1).CardRank != HandToCompareToList.ElementAt(1).CardRank)
            {
                if (HandList.ElementAt(1).CardRank > HandToCompareToList.ElementAt(1).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else
            {
                return 0;
            }
        }

        private int TieBreakerTwoPair(PokerHand HandToCompareTo)
        {
            List<Card> HandList = new List<Card>();
            List<Card> HandToCompareToList = new List<Card>();
            Card TmpCard1 = new Card();
            Card TmpCard2 = new Card();
            Rank Rank1, Rank2;

            HandList.AddRange(Hand);
            HandToCompareToList.AddRange(HandToCompareTo.Hand);

            HandList.Sort();
            HandToCompareToList.Sort();

            int i = 0;
            for(; i < 4; ++i)
            {
                Rank1 = HandList.ElementAt(i).CardRank;
                Rank2 = HandList.ElementAt(i + 1).CardRank;

                if (Rank1 == Rank2)
                {
                    break;
                }
            }

            TmpCard1.CardRank = HandList.ElementAt(i).CardRank;
            TmpCard1.CardSuit = HandList.ElementAt(i).CardSuit;

            HandList.RemoveAt(i + 1);
            HandList.RemoveAt(i);

            for (i = 0; i < 4; ++i)
            {
                Rank1 = HandList.ElementAt(i).CardRank;
                Rank2 = HandList.ElementAt(i + 1).CardRank;

                if (Rank1 == Rank2)
                {
                    break;
                }
            }

            TmpCard2.CardRank = HandList.ElementAt(i).CardRank;
            TmpCard2.CardSuit = HandList.ElementAt(i).CardSuit;

            HandList.RemoveAt(i + 1);
            HandList.RemoveAt(i);

            if (TmpCard1.CardRank > TmpCard2.CardRank)
            {
                HandList.Insert(0, TmpCard2);
                HandList.Insert(0, TmpCard1);
            }

            else
            {
                HandList.Insert(0, TmpCard1);
                HandList.Insert(0, TmpCard2);
            }
            

            for (; i < 4; ++i)
            {
                Rank1 = HandToCompareToList.ElementAt(i).CardRank;
                Rank2 = HandToCompareToList.ElementAt(i + 1).CardRank;

                if (Rank1 == Rank2)
                {
                    break;
                }
            }

            TmpCard1.CardRank = HandToCompareToList.ElementAt(i).CardRank;
            TmpCard1.CardSuit = HandToCompareToList.ElementAt(i).CardSuit;

            HandToCompareToList.RemoveAt(i + 1);
            HandToCompareToList.RemoveAt(i);

            for (i = 0; i < 4; ++i)
            {
                Rank1 = HandToCompareToList.ElementAt(i).CardRank;
                Rank2 = HandToCompareToList.ElementAt(i + 1).CardRank;

                if (Rank1 == Rank2)
                {
                    break;
                }
            }

            TmpCard2.CardRank = HandToCompareToList.ElementAt(i).CardRank;
            TmpCard2.CardSuit = HandToCompareToList.ElementAt(i).CardSuit;

            HandToCompareToList.RemoveAt(i + 1);
            HandToCompareToList.RemoveAt(i);

            if (TmpCard1.CardRank > TmpCard2.CardRank)
            {
                HandToCompareToList.Insert(0, TmpCard2);
                HandToCompareToList.Insert(0, TmpCard1);
            }

            else
            {
                HandToCompareToList.Insert(0, TmpCard1);
                HandToCompareToList.Insert(0, TmpCard2);
            }

            if (HandList.ElementAt(0).CardRank != HandToCompareToList.ElementAt(0).CardRank)
            {
                if (HandList.ElementAt(0).CardRank > HandToCompareToList.ElementAt(0).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else if (HandList.ElementAt(1).CardRank != HandToCompareToList.ElementAt(1).CardRank)
            {
                if (HandList.ElementAt(1).CardRank > HandToCompareToList.ElementAt(1).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else if (HandList.ElementAt(2).CardRank != HandToCompareToList.ElementAt(2).CardRank)
            {
                if (HandList.ElementAt(2).CardRank > HandToCompareToList.ElementAt(2).CardRank)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else
            {
                return 0;
            }
        }

        public int CompareTo(PokerHand HandToCompareTo)
        {
            bool HandCategoryFound = false;
            bool HandToCompareToCategoryFound = false;

            HandType HandType = HandType.OnePair;
            HandType HandToCompareToType = HandType.OnePair;

            //Figure out what type the first hand is
            HandCategoryFound = IsOnePair();
            if (!HandCategoryFound)
            {
                HandCategoryFound = IsTwoPair();
                HandType = HandType.TwoPair;
            }

            if (!HandCategoryFound)
            {
                HandCategoryFound = IsThreeOfAKind();
                HandType = HandType.ThreeOfAKind;
            }

            if (!HandCategoryFound)
            {
                HandCategoryFound = IsStraightFlush();
                HandType = HandType.StraightFlush;
            }

            if (!HandCategoryFound)
            {
                HandCategoryFound = IsFlush();
                HandType = HandType.Flush;
            }

            if (!HandCategoryFound)
            {
                HandCategoryFound = IsFullHouse();
                HandType = HandType.FullHouse;
            }

            if (!HandCategoryFound)
            {
                HandCategoryFound = IsFourOfAKind();
                HandType = HandType.FourOfAKind;
            }

            if (!HandCategoryFound)
            {
                HandCategoryFound = IsStraight();
                HandType = HandType.Straight;
            }

            if (!HandCategoryFound)
            {
                HandType = HandType.HighCard;
            }

            //figure out what type the second hand is
            HandToCompareToCategoryFound = HandToCompareTo.IsOnePair();
            if (!HandToCompareToCategoryFound)
            {
                HandToCompareToCategoryFound = HandToCompareTo.IsTwoPair();
                HandToCompareToType = HandType.TwoPair;
            }

            if (!HandToCompareToCategoryFound)
            {
                HandToCompareToCategoryFound = HandToCompareTo.IsThreeOfAKind();
                HandToCompareToType = HandType.ThreeOfAKind;
            }

            if (!HandToCompareToCategoryFound)
            {
                HandToCompareToCategoryFound = HandToCompareTo.IsStraightFlush();
                HandToCompareToType = HandType.StraightFlush;
            }

            if (!HandToCompareToCategoryFound)
            {
                HandToCompareToCategoryFound = HandToCompareTo.IsFlush();
                HandToCompareToType = HandType.Flush;
            }

            if (!HandToCompareToCategoryFound)
            {
                HandToCompareToCategoryFound = HandToCompareTo.IsFullHouse();
                HandToCompareToType = HandType.FullHouse;
            }

            if (!HandToCompareToCategoryFound)
            {
                HandToCompareToCategoryFound = HandToCompareTo.IsFourOfAKind();
                HandToCompareToType = HandType.FourOfAKind;
            }

            if (!HandToCompareToCategoryFound)
            {
                HandToCompareToCategoryFound = HandToCompareTo.IsStraight();
                HandToCompareToType = HandType.Straight;
            }

            if (!HandToCompareToCategoryFound)
            {
                HandToCompareToType = HandType.HighCard;
            }

            //compare hands
            if (HandType != HandToCompareToType)
            {
                int Diff = HandType - HandToCompareToType;

                if (Diff > 0)
                {
                    return 1;
                }

                else
                {
                    return -1;
                }
            }

            else
            {
                switch (HandType)
                {
                    case HandType.HighCard:
                    case HandType.Flush:
                        return TieBreakerHighCardOrFlush(HandToCompareTo);
                        break;
                    case HandType.OnePair:
                        return TieBreakerOnePair(HandToCompareTo);
                        break;
                    case HandType.TwoPair:
                        return TieBreakerTwoPair(HandToCompareTo);
                        break;
                    case HandType.ThreeOfAKind:
                        return TieBreakerThreeOfAKind(HandToCompareTo);
                        break;
                    case HandType.Straight:
                    case HandType.StraightFlush:
                        return TieBreakerStraightOrStraighFlush(HandToCompareTo);
                        break;
                    case HandType.FullHouse:
                        return TieBreakerFullHouse(HandToCompareTo);
                        break;
                    case HandType.FourOfAKind:
                        return TieBreakerFourOfAKind(HandToCompareTo);
                        break;
                    default:
                        throw new Exception("Couldn't detect hand type.");
                }
            }
        }
    }
}