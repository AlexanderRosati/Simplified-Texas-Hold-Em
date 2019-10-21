using Microsoft.VisualStudio.TestTools.UnitTesting;
using HeadsUpHoldemOddsCalculator;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTieBreakerStraightFlush()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[10];
            int[] IntArray = new int[10];

            for (int i = 0; i < 10; ++i) PokerHandArray[i] = new PokerHand();

            PokerHandArray[0].Hand[0].CardRank = Rank.Ten;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[1].CardRank = Rank.Nine;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[2].CardRank = Rank.Eight;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[3].CardRank = Rank.Seven;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[4].CardRank = Rank.Six;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Club;


            PokerHandArray[1].Hand[0].CardRank = Rank.Eight;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[1].CardRank = Rank.Seven;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[2].CardRank = Rank.Six;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[3].CardRank = Rank.Five;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[4].CardRank = Rank.Four;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Heart;


            PokerHandArray[2].Hand[0].CardRank = Rank.Three;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[1].CardRank = Rank.Six;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[2].CardRank = Rank.Two;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[3].CardRank = Rank.Five;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[4].CardRank = Rank.Four;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Spade;


            PokerHandArray[3].Hand[0].CardRank = Rank.Seven;
            PokerHandArray[3].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[3].Hand[1].CardRank = Rank.Six;
            PokerHandArray[3].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[3].Hand[2].CardRank = Rank.Five;
            PokerHandArray[3].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[3].Hand[3].CardRank = Rank.Four;
            PokerHandArray[3].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray[3].Hand[4].CardRank = Rank.Three;
            PokerHandArray[3].Hand[4].CardSuit = Suit.Diamond;


            PokerHandArray[4].Hand[0].CardRank = Rank.Seven;
            PokerHandArray[4].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[4].Hand[1].CardRank = Rank.Six;
            PokerHandArray[4].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[4].Hand[2].CardRank = Rank.Five;
            PokerHandArray[4].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[4].Hand[3].CardRank = Rank.Four;
            PokerHandArray[4].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[4].Hand[4].CardRank = Rank.Three;
            PokerHandArray[4].Hand[4].CardSuit = Suit.Spade;

            //Act
            IntArray[0] = PokerHandArray[0].CompareTo(PokerHandArray[1]);
            IntArray[1] = PokerHandArray[2].CompareTo(PokerHandArray[1]);
            IntArray[2] = PokerHandArray[3].CompareTo(PokerHandArray[4]);

            //Assert
            Assert.AreEqual(1, IntArray[0]);
            Assert.AreEqual(-1, IntArray[1]);
            Assert.AreEqual(0, IntArray[2]);
        }

        [TestMethod]
        public void TestTieBreakerFourOfAKind()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[10];
            int[] IntArray = new int[10];

            for (int i = 0; i < 10; ++i) PokerHandArray[i] = new PokerHand();

            PokerHandArray[0].Hand[0].CardRank = Rank.King;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[0].Hand[1].CardRank = Rank.King;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[0].Hand[2].CardRank = Rank.King;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[3].CardRank = Rank.King;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray[0].Hand[4].CardRank = Rank.Three;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Heart;


            PokerHandArray[1].Hand[0].CardRank = Rank.Seven;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[1].Hand[1].CardRank = Rank.Seven;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[2].CardRank = Rank.Queen;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[3].CardRank = Rank.Seven;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray[1].Hand[4].CardRank = Rank.Seven;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Spade;


            PokerHandArray[2].Hand[0].CardRank = Rank.Seven;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Heart;

            PokerHandArray[2].Hand[1].CardRank = Rank.Seven;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[2].CardRank = Rank.Seven;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[3].CardRank = Rank.Seven;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[2].Hand[4].CardRank = Rank.Ten;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Spade;


            PokerHandArray[3].Hand[0].CardRank = Rank.Four;
            PokerHandArray[3].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[3].Hand[1].CardRank = Rank.Four;
            PokerHandArray[3].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[3].Hand[2].CardRank = Rank.Four;
            PokerHandArray[3].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[3].Hand[3].CardRank = Rank.Four;
            PokerHandArray[3].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[3].Hand[4].CardRank = Rank.Nine;
            PokerHandArray[3].Hand[4].CardSuit = Suit.Club;


            PokerHandArray[4].Hand[0].CardRank = Rank.Four;
            PokerHandArray[4].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[4].Hand[1].CardRank = Rank.Four;
            PokerHandArray[4].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[4].Hand[2].CardRank = Rank.Four;
            PokerHandArray[4].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[4].Hand[3].CardRank = Rank.Four;
            PokerHandArray[4].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[4].Hand[4].CardRank = Rank.Nine;
            PokerHandArray[4].Hand[4].CardSuit = Suit.Diamond;

            //Act
            IntArray[0] = PokerHandArray[0].CompareTo(PokerHandArray[1]);
            IntArray[1] = PokerHandArray[2].CompareTo(PokerHandArray[1]);
            IntArray[2] = PokerHandArray[4].CompareTo(PokerHandArray[3]);

            //Assert
            Assert.AreEqual(1, IntArray[0]);
            Assert.AreEqual(-1, IntArray[1]);
            Assert.AreEqual(0, IntArray[2]);

        }

        [TestMethod]
        public void TestTieBreakerFullHouse()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[10];
            int[] IntArray = new int[10];

            for (int i = 0; i < 10; ++i) PokerHandArray[i] = new PokerHand();

            PokerHandArray[0].Hand[0].CardRank = Rank.Eight;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[0].Hand[1].CardRank = Rank.Eight;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[0].Hand[2].CardRank = Rank.Eight;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[0].Hand[3].CardRank = Rank.Seven;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray[0].Hand[4].CardRank = Rank.Seven;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Club;


            PokerHandArray[1].Hand[0].CardRank = Rank.Nine;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[1].Hand[1].CardRank = Rank.Four;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[1].Hand[2].CardRank = Rank.Nine;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[1].Hand[3].CardRank = Rank.Four;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[1].Hand[4].CardRank = Rank.Four;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Club;


            PokerHandArray[2].Hand[0].CardRank = Rank.Four;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[1].CardRank = Rank.Four;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[2].CardRank = Rank.Four;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[2].Hand[3].CardRank = Rank.Five;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[2].Hand[4].CardRank = Rank.Five;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Diamond;


            PokerHandArray[3].Hand[0].CardRank = Rank.King;
            PokerHandArray[3].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[3].Hand[1].CardRank = Rank.King;
            PokerHandArray[3].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[3].Hand[2].CardRank = Rank.King;
            PokerHandArray[3].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[3].Hand[3].CardRank = Rank.Jack;
            PokerHandArray[3].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[3].Hand[4].CardRank = Rank.Jack;
            PokerHandArray[3].Hand[4].CardSuit = Suit.Spade;


            PokerHandArray[4].Hand[0].CardRank = Rank.King;
            PokerHandArray[4].Hand[0].CardSuit = Suit.Club;
        
            PokerHandArray[4].Hand[1].CardRank = Rank.King;
            PokerHandArray[4].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[4].Hand[2].CardRank = Rank.King;
            PokerHandArray[4].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[4].Hand[3].CardRank = Rank.Jack;
            PokerHandArray[4].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[4].Hand[4].CardRank = Rank.Jack;
            PokerHandArray[4].Hand[4].CardSuit = Suit.Heart;

            //Act
            IntArray[0] = PokerHandArray[0].CompareTo(PokerHandArray[1]);
            IntArray[1] = PokerHandArray[2].CompareTo(PokerHandArray[1]);
            IntArray[2] = PokerHandArray[4].CompareTo(PokerHandArray[3]);

            //Assert
            Assert.AreEqual(1, IntArray[0]);
            Assert.AreEqual(-1, IntArray[1]);
            Assert.AreEqual(0, IntArray[2]);
        }
        
        [TestMethod]
        public void TestTieBreakerFlush()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[10];
            int[] IntArray = new int[10];

            for (int i = 0; i < 10; ++i) PokerHandArray[i] = new PokerHand();

            PokerHandArray[0].Hand[0].CardRank = Rank.King;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[0].Hand[1].CardRank = Rank.Jack;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[0].Hand[2].CardRank = Rank.Nine;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[0].Hand[3].CardRank = Rank.Six;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray[0].Hand[4].CardRank = Rank.Four;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Diamond;


            PokerHandArray[1].Hand[0].CardRank = Rank.Queen;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[1].Hand[1].CardRank = Rank.Jack;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Club;

            PokerHandArray[1].Hand[2].CardRank = Rank.Seven;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[1].Hand[3].CardRank = Rank.Six;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[1].Hand[4].CardRank = Rank.Five;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Club;


            PokerHandArray[2].Hand[0].CardRank = Rank.Jack;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Heart;

            PokerHandArray[2].Hand[1].CardRank = Rank.Ten;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[2].Hand[2].CardRank = Rank.Nine;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[2].Hand[3].CardRank = Rank.Four;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[2].Hand[4].CardRank = Rank.Two;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Heart;


            PokerHandArray[3].Hand[0].CardRank = Rank.Jack;
            PokerHandArray[3].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[3].Hand[1].CardRank = Rank.Ten;
            PokerHandArray[3].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[3].Hand[2].CardRank = Rank.Eight;
            PokerHandArray[3].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[3].Hand[3].CardRank = Rank.Six;
            PokerHandArray[3].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[3].Hand[4].CardRank = Rank.Three;
            PokerHandArray[3].Hand[4].CardSuit = Suit.Spade;


            PokerHandArray[4].Hand[0].CardRank = Rank.Three;
            PokerHandArray[4].Hand[0].CardSuit = Suit.Heart;

            PokerHandArray[4].Hand[1].CardRank = Rank.Jack;
            PokerHandArray[4].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[4].Hand[2].CardRank = Rank.Ten;
            PokerHandArray[4].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[4].Hand[3].CardRank = Rank.Four;
            PokerHandArray[4].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[4].Hand[4].CardRank = Rank.Eight;
            PokerHandArray[4].Hand[4].CardSuit = Suit.Heart;


            PokerHandArray[5].Hand[0].CardRank = Rank.Jack;
            PokerHandArray[5].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[5].Hand[1].CardRank = Rank.Ten;
            PokerHandArray[5].Hand[1].CardSuit = Suit.Club;

            PokerHandArray[5].Hand[2].CardRank = Rank.Eight;
            PokerHandArray[5].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[5].Hand[3].CardRank = Rank.Four;
            PokerHandArray[5].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[5].Hand[4].CardRank = Rank.Two;
            PokerHandArray[5].Hand[4].CardSuit = Suit.Club;


            PokerHandArray[6].Hand[0].CardRank = Rank.Ten;
            PokerHandArray[6].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[6].Hand[1].CardRank = Rank.Eight;
            PokerHandArray[6].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[6].Hand[2].CardRank = Rank.Seven;
            PokerHandArray[6].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[6].Hand[3].CardRank = Rank.Six;
            PokerHandArray[6].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray[6].Hand[4].CardRank = Rank.Five;
            PokerHandArray[6].Hand[4].CardSuit = Suit.Diamond;


            PokerHandArray[7].Hand[0].CardRank = Rank.Ten;
            PokerHandArray[7].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[7].Hand[1].CardRank = Rank.Eight;
            PokerHandArray[7].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[7].Hand[2].CardRank = Rank.Seven;
            PokerHandArray[7].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[7].Hand[3].CardRank = Rank.Six;
            PokerHandArray[7].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[7].Hand[4].CardRank = Rank.Five;
            PokerHandArray[7].Hand[4].CardSuit = Suit.Spade;

            //Act
            IntArray[0] = PokerHandArray[0].CompareTo(PokerHandArray[1]);
            IntArray[1] = PokerHandArray[2].CompareTo(PokerHandArray[1]);
            IntArray[2] = PokerHandArray[2].CompareTo(PokerHandArray[3]);
            IntArray[3] = PokerHandArray[4].CompareTo(PokerHandArray[3]);
            IntArray[4] = PokerHandArray[4].CompareTo(PokerHandArray[5]);
            IntArray[5] = PokerHandArray[7].CompareTo(PokerHandArray[6]);

            //Assert
            Assert.AreEqual(1, IntArray[0]);
            Assert.AreEqual(-1, IntArray[1]);
            Assert.AreEqual(1, IntArray[2]);
            Assert.AreEqual(-1, IntArray[3]);
            Assert.AreEqual(1, IntArray[4]);
            Assert.AreEqual(0, IntArray[5]);
        }

        [TestMethod]
        public void TestTieBreakerStraight()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[10];
            int[] IntArray = new int[10];

            for (int i = 0; i < 10; ++i) PokerHandArray[i] = new PokerHand();

            PokerHandArray[0].Hand[0].CardRank = Rank.Jack;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Heart;

            PokerHandArray[0].Hand[1].CardRank = Rank.Ten;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[0].Hand[2].CardRank = Rank.Nine;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[3].CardRank = Rank.Eight;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[0].Hand[4].CardRank = Rank.Seven;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Heart;


            PokerHandArray[1].Hand[0].CardRank = Rank.Ten;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[1].Hand[1].CardRank = Rank.Nine;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[1].Hand[2].CardRank = Rank.Eight;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[1].Hand[3].CardRank = Rank.Seven;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[4].CardRank = Rank.Six;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Spade;


            PokerHandArray[2].Hand[0].CardRank = Rank.Three;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[1].CardRank = Rank.Six;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Club;

            PokerHandArray[2].Hand[2].CardRank = Rank.Five;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[3].CardRank = Rank.Two;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[4].CardRank = Rank.Four;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Heart;


            PokerHandArray[3].Hand[0].CardRank = Rank.Nine;
            PokerHandArray[3].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[3].Hand[1].CardRank = Rank.Eight;
            PokerHandArray[3].Hand[1].CardSuit = Suit.Club;

            PokerHandArray[3].Hand[2].CardRank = Rank.Seven;
            PokerHandArray[3].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[3].Hand[3].CardRank = Rank.Six;
            PokerHandArray[3].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray[3].Hand[4].CardRank = Rank.Five;
            PokerHandArray[3].Hand[4].CardSuit = Suit.Diamond;


            PokerHandArray[4].Hand[0].CardRank = Rank.Nine;
            PokerHandArray[4].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[4].Hand[1].CardRank = Rank.Eight;
            PokerHandArray[4].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[4].Hand[2].CardRank = Rank.Seven;
            PokerHandArray[4].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[4].Hand[3].CardRank = Rank.Six;
            PokerHandArray[4].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[4].Hand[4].CardRank = Rank.Five;
            PokerHandArray[4].Hand[4].CardSuit = Suit.Heart;

            //Act
            IntArray[0] = PokerHandArray[0].CompareTo(PokerHandArray[1]);
            IntArray[1] = PokerHandArray[2].CompareTo(PokerHandArray[1]);
            IntArray[2] = PokerHandArray[4].CompareTo(PokerHandArray[3]);

            //Assert
            Assert.AreEqual(1, IntArray[0]);
            Assert.AreEqual(-1, IntArray[1]);
            Assert.AreEqual(0, IntArray[2]);
        }

        [TestMethod]
        public void TestTieBreakerThreeOfAKind()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[10];
            int[] IntArray = new int[10];

            for (int i = 0; i < 10; ++i) PokerHandArray[i] = new PokerHand();

            PokerHandArray[0].Hand[0].CardRank = Rank.Queen;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[1].CardRank = Rank.Six;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[0].Hand[2].CardRank = Rank.Six;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[0].Hand[3].CardRank = Rank.Four;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[0].Hand[4].CardRank = Rank.Six;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Spade;


            PokerHandArray[1].Hand[0].CardRank = Rank.Three;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[1].Hand[1].CardRank = Rank.Three;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[1].Hand[2].CardRank = Rank.Three;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[1].Hand[3].CardRank = Rank.King;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[1].Hand[4].CardRank = Rank.Two;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Spade;


            PokerHandArray[2].Hand[0].CardRank = Rank.Three;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[1].CardRank = Rank.Three;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[2].CardRank = Rank.Three;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[2].Hand[3].CardRank = Rank.Jack;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[2].Hand[4].CardRank = Rank.Seven;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Heart;


            PokerHandArray[3].Hand[0].CardRank = Rank.Three;
            PokerHandArray[3].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[3].Hand[1].CardRank = Rank.Three;
            PokerHandArray[3].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[3].Hand[2].CardRank = Rank.Three;
            PokerHandArray[3].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[3].Hand[3].CardRank = Rank.Jack;
            PokerHandArray[3].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[3].Hand[4].CardRank = Rank.Five;
            PokerHandArray[3].Hand[4].CardSuit = Suit.Diamond;


            PokerHandArray[4].Hand[0].CardRank = Rank.Nine;
            PokerHandArray[4].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[4].Hand[1].CardRank = Rank.Nine;
            PokerHandArray[4].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[4].Hand[2].CardRank = Rank.Nine;
            PokerHandArray[4].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[4].Hand[3].CardRank = Rank.Ten;
            PokerHandArray[4].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray[4].Hand[4].CardRank = Rank.Eight;
            PokerHandArray[4].Hand[4].CardSuit = Suit.Heart;


            PokerHandArray[5].Hand[0].CardRank = Rank.Nine;
            PokerHandArray[5].Hand[0].CardSuit = Suit.Club;
        
            PokerHandArray[5].Hand[1].CardRank = Rank.Nine;
            PokerHandArray[5].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[5].Hand[2].CardRank = Rank.Nine;
            PokerHandArray[5].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[5].Hand[3].CardRank = Rank.Ten;
            PokerHandArray[5].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray[5].Hand[4].CardRank = Rank.Eight;
            PokerHandArray[5].Hand[4].CardSuit = Suit.Diamond;

            //Act
            IntArray[0] = PokerHandArray[0].CompareTo(PokerHandArray[1]);
            IntArray[1] = PokerHandArray[2].CompareTo(PokerHandArray[1]);
            IntArray[2] = PokerHandArray[2].CompareTo(PokerHandArray[3]);
            IntArray[3] = PokerHandArray[5].CompareTo(PokerHandArray[4]);

            //Assert
            Assert.AreEqual(1, IntArray[0]);
            Assert.AreEqual(-1, IntArray[1]);
            Assert.AreEqual(1, IntArray[2]);
            Assert.AreEqual(0, IntArray[3]);
        }

        [TestMethod]
        public void TestTieBreakerTwoPair()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[10];
            int[] IntArray = new int[10];

            for (int i = 0; i < 10; ++i) PokerHandArray[i] = new PokerHand();

            PokerHandArray[0].Hand[0].CardRank = Rank.Two;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[1].CardRank = Rank.Ten;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[0].Hand[2].CardRank = Rank.Ten;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[0].Hand[3].CardRank = Rank.King;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[4].CardRank = Rank.Two;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Spade;


            PokerHandArray[1].Hand[0].CardRank = Rank.Five;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[1].Hand[1].CardRank = Rank.Five;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[1].Hand[2].CardRank = Rank.Four;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[1].Hand[3].CardRank = Rank.Four;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[4].CardRank = Rank.Ten;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Heart;


            PokerHandArray[2].Hand[0].CardRank = Rank.Five;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[2].Hand[1].CardRank = Rank.Five;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[2].CardRank = Rank.Three;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[2].Hand[3].CardRank = Rank.Three;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[4].CardRank = Rank.Queen;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Spade;


            PokerHandArray[3].Hand[0].CardRank = Rank.Five;
            PokerHandArray[3].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[3].Hand[1].CardRank = Rank.Five;
            PokerHandArray[3].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[3].Hand[2].CardRank = Rank.Three;
            PokerHandArray[3].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[3].Hand[3].CardRank = Rank.Three;
            PokerHandArray[3].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray[3].Hand[4].CardRank = Rank.Jack;
            PokerHandArray[3].Hand[4].CardSuit = Suit.Spade;


            PokerHandArray[4].Hand[0].CardRank = Rank.King;
            PokerHandArray[4].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[4].Hand[1].CardRank = Rank.King;
            PokerHandArray[4].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[4].Hand[2].CardRank = Rank.Seven;
            PokerHandArray[4].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[4].Hand[3].CardRank = Rank.Seven;
            PokerHandArray[4].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[4].Hand[4].CardRank = Rank.Eight;
            PokerHandArray[4].Hand[4].CardSuit = Suit.Heart;


            PokerHandArray[5].Hand[0].CardRank = Rank.King;
            PokerHandArray[5].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[5].Hand[1].CardRank = Rank.King;
            PokerHandArray[5].Hand[1].CardSuit = Suit.Spade;
        
            PokerHandArray[5].Hand[2].CardRank = Rank.Seven;
            PokerHandArray[5].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[5].Hand[3].CardRank = Rank.Seven;
            PokerHandArray[5].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[5].Hand[4].CardRank = Rank.Eight;
            PokerHandArray[5].Hand[4].CardSuit = Suit.Club;

            //Act
            IntArray[0] = PokerHandArray[0].CompareTo(PokerHandArray[1]);
            IntArray[1] = PokerHandArray[2].CompareTo(PokerHandArray[1]);
            IntArray[2] = PokerHandArray[2].CompareTo(PokerHandArray[3]);
            IntArray[3] = PokerHandArray[5].CompareTo(PokerHandArray[4]);

            //Assert
            Assert.AreEqual(1, IntArray[0]);
            Assert.AreEqual(-1, IntArray[1]);
            Assert.AreEqual(1, IntArray[2]);
            Assert.AreEqual(0, IntArray[3]);
        }

        [TestMethod]
        public void TestTieBreakerOnePair()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[10];
            int[] IntArray = new int[10];

            for (int i = 0; i < 10; ++i) PokerHandArray[i] = new PokerHand();

            PokerHandArray[0].Hand[0].CardRank = Rank.Nine;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[1].CardRank = Rank.Nine;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[0].Hand[2].CardRank = Rank.Queen;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[0].Hand[3].CardRank = Rank.Jack;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[0].Hand[4].CardRank = Rank.Five;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Heart;


            PokerHandArray[1].Hand[0].CardRank = Rank.Six;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[1].Hand[1].CardRank = Rank.Six;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[2].CardRank = Rank.King;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[1].Hand[3].CardRank = Rank.Seven;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[4].CardRank = Rank.Four;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Club;


            PokerHandArray[2].Hand[0].CardRank = Rank.Queen;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Heart;

            PokerHandArray[2].Hand[1].CardRank = Rank.Six;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[2].CardRank = Rank.Jack;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[3].CardRank = Rank.Six;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[2].Hand[4].CardRank = Rank.Two;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Club;


            PokerHandArray[3].Hand[0].CardRank = Rank.Six;
            PokerHandArray[3].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[3].Hand[1].CardRank = Rank.Six;
            PokerHandArray[3].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[3].Hand[2].CardRank = Rank.Queen;
            PokerHandArray[3].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[3].Hand[3].CardRank = Rank.Eight;
            PokerHandArray[3].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[3].Hand[4].CardRank = Rank.Seven;
            PokerHandArray[3].Hand[4].CardSuit = Suit.Diamond;


            PokerHandArray[4].Hand[0].CardRank = Rank.Six;
            PokerHandArray[4].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[4].Hand[1].CardRank = Rank.Six;
            PokerHandArray[4].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[4].Hand[2].CardRank = Rank.Queen;
            PokerHandArray[4].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[4].Hand[3].CardRank = Rank.Eight;
            PokerHandArray[4].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[4].Hand[4].CardRank = Rank.Three;
            PokerHandArray[4].Hand[4].CardSuit = Suit.Spade;


            PokerHandArray[5].Hand[0].CardRank = Rank.Eight;
            PokerHandArray[5].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[5].Hand[1].CardRank = Rank.Eight;
            PokerHandArray[5].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[5].Hand[2].CardRank = Rank.Ten;
            PokerHandArray[5].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[5].Hand[3].CardRank = Rank.Six;
            PokerHandArray[5].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[5].Hand[4].CardRank = Rank.Five;
            PokerHandArray[5].Hand[4].CardSuit = Suit.Spade;


            PokerHandArray[6].Hand[0].CardRank = Rank.Eight;
            PokerHandArray[6].Hand[0].CardSuit = Suit.Heart;
        
            PokerHandArray[6].Hand[1].CardRank = Rank.Eight;
            PokerHandArray[6].Hand[1].CardSuit = Suit.Club;

            PokerHandArray[6].Hand[2].CardRank = Rank.Ten;
            PokerHandArray[6].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[6].Hand[3].CardRank = Rank.Six;
            PokerHandArray[6].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[6].Hand[4].CardRank = Rank.Five;
            PokerHandArray[6].Hand[4].CardSuit = Suit.Club;

            //Act
            IntArray[0] = PokerHandArray[0].CompareTo(PokerHandArray[1]);
            IntArray[1] = PokerHandArray[2].CompareTo(PokerHandArray[1]);
            IntArray[2] = PokerHandArray[2].CompareTo(PokerHandArray[3]);
            IntArray[3] = PokerHandArray[4].CompareTo(PokerHandArray[3]);
            IntArray[4] = PokerHandArray[6].CompareTo(PokerHandArray[5]);

            //Assert
            Assert.AreEqual(1, IntArray[0]);
            Assert.AreEqual(-1, IntArray[1]);
            Assert.AreEqual(1, IntArray[2]);
            Assert.AreEqual(-1, IntArray[3]);
            Assert.AreEqual(0, IntArray[4]);
        }

        [TestMethod]
        public void TestTieBreakerHighCard()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[10];
            int[] IntArray = new int[10];

            for (int i = 0; i < 10; ++i) PokerHandArray[i] = new PokerHand();

            PokerHandArray[0].Hand[0].CardRank = Rank.King;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[0].Hand[1].CardRank = Rank.Six;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[2].CardRank = Rank.Five;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[0].Hand[3].CardRank = Rank.Three;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray[0].Hand[4].CardRank = Rank.Two;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Club;


            PokerHandArray[1].Hand[0].CardRank = Rank.Queen;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[1].Hand[1].CardRank = Rank.Jack;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[1].Hand[2].CardRank = Rank.Six;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[1].Hand[3].CardRank = Rank.Five;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[4].CardRank = Rank.Three;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Club;


            PokerHandArray[2].Hand[0].CardRank = Rank.Queen;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[1].CardRank = Rank.Ten;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[2].CardRank = Rank.Eight;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[2].Hand[3].CardRank = Rank.Seven;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[4].CardRank = Rank.Four;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Spade;


            PokerHandArray[3].Hand[0].CardRank = Rank.Queen;
            PokerHandArray[3].Hand[0].CardSuit = Suit.Heart;

            PokerHandArray[3].Hand[1].CardRank = Rank.Ten;
            PokerHandArray[3].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[3].Hand[2].CardRank = Rank.Seven;
            PokerHandArray[3].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[3].Hand[3].CardRank = Rank.Six;
            PokerHandArray[3].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[3].Hand[4].CardRank = Rank.Four;
            PokerHandArray[3].Hand[4].CardSuit = Suit.Spade;


            PokerHandArray[4].Hand[0].CardRank = Rank.Queen;
            PokerHandArray[4].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[4].Hand[1].CardRank = Rank.Ten;
            PokerHandArray[4].Hand[1].CardSuit = Suit.Club;

            PokerHandArray[4].Hand[2].CardRank = Rank.Seven;
            PokerHandArray[4].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[4].Hand[3].CardRank = Rank.Five;
            PokerHandArray[4].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[4].Hand[4].CardRank = Rank.Four;
            PokerHandArray[4].Hand[4].CardSuit = Suit.Diamond;


            PokerHandArray[5].Hand[0].CardRank = Rank.Five;
            PokerHandArray[5].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[5].Hand[1].CardRank = Rank.Queen;
            PokerHandArray[5].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[5].Hand[2].CardRank = Rank.Two;
            PokerHandArray[5].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[5].Hand[3].CardRank = Rank.Seven;
            PokerHandArray[5].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[5].Hand[4].CardRank = Rank.Ten;
            PokerHandArray[5].Hand[4].CardSuit = Suit.Diamond;


            PokerHandArray[6].Hand[0].CardRank = Rank.Ten;
            PokerHandArray[6].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[6].Hand[1].CardRank = Rank.Eight;
            PokerHandArray[6].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[6].Hand[2].CardRank = Rank.Seven;
            PokerHandArray[6].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[6].Hand[3].CardRank = Rank.Six;
            PokerHandArray[6].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[6].Hand[4].CardRank = Rank.Four;
            PokerHandArray[6].Hand[4].CardSuit = Suit.Diamond;


            PokerHandArray[7].Hand[0].CardRank = Rank.Ten;
            PokerHandArray[7].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[7].Hand[1].CardRank = Rank.Eight;
            PokerHandArray[7].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[7].Hand[2].CardRank = Rank.Seven;
            PokerHandArray[7].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[7].Hand[3].CardRank = Rank.Six;
            PokerHandArray[7].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[7].Hand[4].CardRank = Rank.Four;
            PokerHandArray[7].Hand[4].CardSuit = Suit.Club;

            //Act
            IntArray[0] = PokerHandArray[0].CompareTo(PokerHandArray[1]);
            IntArray[1] = PokerHandArray[2].CompareTo(PokerHandArray[1]);
            IntArray[2] = PokerHandArray[2].CompareTo(PokerHandArray[3]);
            IntArray[3] = PokerHandArray[4].CompareTo(PokerHandArray[3]);
            IntArray[4] = PokerHandArray[4].CompareTo(PokerHandArray[5]);
            IntArray[5] = PokerHandArray[6].CompareTo(PokerHandArray[7]);

            //Assert
            Assert.AreEqual(1, IntArray[0]);
            Assert.AreEqual(-1, IntArray[1]);
            Assert.AreEqual(1, IntArray[2]);
            Assert.AreEqual(-1, IntArray[3]);
            Assert.AreEqual(1, IntArray[4]);
            Assert.AreEqual(0, IntArray[5]);
        }

        [TestMethod]
        public void TestCompareToBasic()
        {
            //Arrange
            PokerHand[] PokerHandArray1 = new PokerHand[50];
            PokerHand[] PokerHandArray2 = new PokerHand[50];
            int[] IntArray = new int[50];

            for (int i = 0; i < 50; ++i) PokerHandArray1[i] = new PokerHand();
            for (int i = 0; i < 50; ++i) PokerHandArray2[i] = new PokerHand();

            /*******************************************/

            PokerHandArray1[0].Hand[0].CardRank = Rank.Ace;
            PokerHandArray1[0].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray1[0].Hand[1].CardRank = Rank.Ace;
            PokerHandArray1[0].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray1[0].Hand[2].CardRank = Rank.Queen;
            PokerHandArray1[0].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray1[0].Hand[3].CardRank = Rank.Eight;
            PokerHandArray1[0].Hand[3].CardSuit = Suit.Club;

            PokerHandArray1[0].Hand[4].CardRank = Rank.King;
            PokerHandArray1[0].Hand[4].CardSuit = Suit.Spade;


            PokerHandArray2[0].Hand[0].CardRank = Rank.Four;
            PokerHandArray2[0].Hand[0].CardSuit = Suit.Club;

            PokerHandArray2[0].Hand[1].CardRank = Rank.Four;
            PokerHandArray2[0].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray2[0].Hand[2].CardRank = Rank.Ace;
            PokerHandArray2[0].Hand[2].CardSuit = Suit.Club;

            PokerHandArray2[0].Hand[3].CardRank = Rank.Ace;
            PokerHandArray2[0].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray2[0].Hand[4].CardRank = Rank.Six;
            PokerHandArray2[0].Hand[4].CardSuit = Suit.Spade;

            /*******************************************/

            PokerHandArray1[1].Hand[0].CardRank = Rank.Ace;
            PokerHandArray1[1].Hand[0].CardSuit = Suit.Club;

            PokerHandArray1[1].Hand[1].CardRank = Rank.Ace;
            PokerHandArray1[1].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray1[1].Hand[2].CardRank = Rank.Ace;
            PokerHandArray1[1].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray1[1].Hand[3].CardRank = Rank.Queen;
            PokerHandArray1[1].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray1[1].Hand[4].CardRank = Rank.Nine;
            PokerHandArray1[1].Hand[4].CardSuit = Suit.Heart;


            PokerHandArray2[1].Hand[0].CardRank = Rank.King;
            PokerHandArray2[1].Hand[0].CardSuit = Suit.Heart;

            PokerHandArray2[1].Hand[1].CardRank = Rank.Five;
            PokerHandArray2[1].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray2[1].Hand[2].CardRank = Rank.Eight;
            PokerHandArray2[1].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray2[1].Hand[3].CardRank = Rank.Seven;
            PokerHandArray2[1].Hand[3].CardSuit = Suit.Club;

            PokerHandArray2[1].Hand[4].CardRank = Rank.Ten;
            PokerHandArray2[1].Hand[4].CardSuit = Suit.Heart;

            //Act
            IntArray[0] = PokerHandArray1[0].CompareTo(PokerHandArray2[0]);
            IntArray[1] = PokerHandArray1[1].CompareTo(PokerHandArray2[1]);

            //Assert
            Assert.AreEqual(-1, IntArray[0]);
            Assert.AreEqual(1, IntArray[1]);

        }

        [TestMethod]
        public void TestOnePair()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[3];
            bool[] BoolArray = new bool[3];

            PokerHandArray[0] = new PokerHand();
            PokerHandArray[1] = new PokerHand();
            PokerHandArray[2] = new PokerHand();

            /***************************************************/

            PokerHandArray[0].Hand[0].CardRank = Rank.Two;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[0].Hand[1].CardRank = Rank.Four;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[0].Hand[2].CardRank = Rank.Six;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[0].Hand[3].CardRank = Rank.Seven;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[0].Hand[4].CardRank = Rank.Two;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Heart;

            /***************************************************/

            PokerHandArray[1].Hand[0].CardRank = Rank.Six;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[1].Hand[1].CardRank = Rank.Six;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[1].Hand[2].CardRank = Rank.Queen;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[3].CardRank = Rank.Seven;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[1].Hand[4].CardRank = Rank.Eight;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Heart;

            /***************************************************/

            PokerHandArray[2].Hand[0].CardRank = Rank.King;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Heart;

            PokerHandArray[2].Hand[1].CardRank = Rank.King;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[2].CardRank = Rank.Ten;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[2].Hand[3].CardRank = Rank.Two;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[2].Hand[4].CardRank = Rank.Jack;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Heart;

            /***************************************************/

            //Action
            BoolArray[0] = PokerHandArray[0].IsOnePair();
            BoolArray[1] = PokerHandArray[1].IsOnePair();
            BoolArray[2] = PokerHandArray[2].IsOnePair();

            //Asert
            Assert.IsTrue(BoolArray[0]);
            Assert.IsTrue(BoolArray[1]);
            Assert.IsTrue(BoolArray[2]);
        }

        [TestMethod]
        public void TestTwoPair()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[3];
            bool[] BoolArray = new bool[4];

            PokerHandArray[0] = new PokerHand();
            PokerHandArray[1] = new PokerHand();
            PokerHandArray[2] = new PokerHand();

            /***************************************************/

            PokerHandArray[0].Hand[0].CardRank = Rank.Six;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[0].Hand[1].CardRank = Rank.Six;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[0].Hand[2].CardRank = Rank.Five;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[0].Hand[3].CardRank = Rank.Five;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[0].Hand[4].CardRank = Rank.Ace;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Spade;

            /***************************************************/

            PokerHandArray[1].Hand[0].CardRank = Rank.Eight;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[1].Hand[1].CardRank = Rank.Eight;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[2].CardRank = Rank.Nine;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[3].CardRank = Rank.Nine;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[1].Hand[4].CardRank = Rank.Queen;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Heart;

            /***************************************************/

            PokerHandArray[2].Hand[0].CardRank = Rank.Four;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Heart;

            PokerHandArray[2].Hand[1].CardRank = Rank.Seven;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[2].CardRank = Rank.Four;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[3].CardRank = Rank.Six;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[2].Hand[4].CardRank = Rank.Seven;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Diamond;

            /***************************************************/

            //Action
            BoolArray[0] = PokerHandArray[0].IsTwoPair();
            BoolArray[1] = PokerHandArray[1].IsTwoPair();
            BoolArray[2] = PokerHandArray[2].IsTwoPair();
            BoolArray[3] = PokerHandArray[2].IsOnePair();

            //Assert
            Assert.IsTrue(BoolArray[0]);
            Assert.IsTrue(BoolArray[1]);
            Assert.IsTrue(BoolArray[2]);
            Assert.IsFalse(BoolArray[3]);
        }

        [TestMethod]
        public void TestThreeOfAKind()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[3];
            bool[] BoolArray = new bool[4];

            PokerHandArray[0] = new PokerHand();
            PokerHandArray[1] = new PokerHand();
            PokerHandArray[2] = new PokerHand();

            /***************************************************/

            PokerHandArray[0].Hand[0].CardRank = Rank.Ace;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[1].CardRank = Rank.Four;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[0].Hand[2].CardRank = Rank.Ace;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[0].Hand[3].CardRank = Rank.Three;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[4].CardRank = Rank.Ace;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Diamond;

            /***************************************************/

            PokerHandArray[1].Hand[0].CardRank = Rank.Five;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[1].Hand[1].CardRank = Rank.Five;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[1].Hand[2].CardRank = Rank.Five;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[1].Hand[3].CardRank = Rank.Two;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[4].CardRank = Rank.Jack;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Spade;

            /***************************************************/

            PokerHandArray[2].Hand[0].CardRank = Rank.Seven;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[2].Hand[1].CardRank = Rank.Seven;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[2].CardRank = Rank.Seven;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[3].CardRank = Rank.Queen;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[4].CardRank = Rank.Four;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Club;

            //Act
            BoolArray[0] = PokerHandArray[0].IsThreeOfAKind();
            BoolArray[1] = PokerHandArray[1].IsThreeOfAKind();
            BoolArray[2] = PokerHandArray[2].IsThreeOfAKind();
            BoolArray[3] = PokerHandArray[2].IsFullHouse();

            //Assert
            Assert.IsTrue(BoolArray[0]);
            Assert.IsTrue(BoolArray[1]);
            Assert.IsTrue(BoolArray[2]);
            Assert.IsFalse(BoolArray[3]);
        }

        [TestMethod]
        public void TestStraight()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[12];
            bool[] BoolArray = new bool[12];

            PokerHandArray[0] = new PokerHand();
            PokerHandArray[1] = new PokerHand();
            PokerHandArray[2] = new PokerHand();
            PokerHandArray[3] = new PokerHand();
            PokerHandArray[4] = new PokerHand();
            PokerHandArray[5] = new PokerHand();
            PokerHandArray[6] = new PokerHand();
            PokerHandArray[7] = new PokerHand();
            PokerHandArray[8] = new PokerHand();

            /***************************************************/

            PokerHandArray[0].Hand[0].CardRank = Rank.Two;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[1].CardRank = Rank.Three;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[0].Hand[2].CardRank = Rank.Four;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[0].Hand[3].CardRank = Rank.Five;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[4].CardRank = Rank.Six;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Diamond;

            /***************************************************/

            PokerHandArray[1].Hand[0].CardRank = Rank.Three;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[1].Hand[1].CardRank = Rank.Four;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[2].CardRank = Rank.Five;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[1].Hand[3].CardRank = Rank.Six;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[1].Hand[4].CardRank = Rank.Seven;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Diamond;

            /***************************************************/

            PokerHandArray[2].Hand[0].CardRank = Rank.Four;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[1].CardRank = Rank.Five;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[2].CardRank = Rank.Six;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[2].Hand[3].CardRank = Rank.Seven;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[2].Hand[4].CardRank = Rank.Eight;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Club;

            /***************************************************/

            PokerHandArray[3].Hand[0].CardRank = Rank.Eight;
            PokerHandArray[3].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[3].Hand[1].CardRank = Rank.Seven;
            PokerHandArray[3].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[3].Hand[2].CardRank = Rank.Six;
            PokerHandArray[3].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[3].Hand[3].CardRank = Rank.Nine;
            PokerHandArray[3].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[3].Hand[4].CardRank = Rank.Five;
            PokerHandArray[3].Hand[4].CardSuit = Suit.Club;

            /***************************************************/

            PokerHandArray[4].Hand[0].CardRank = Rank.Six;
            PokerHandArray[4].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[4].Hand[1].CardRank = Rank.Seven;
            PokerHandArray[4].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[4].Hand[2].CardRank = Rank.Eight;
            PokerHandArray[4].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[4].Hand[3].CardRank = Rank.Nine;
            PokerHandArray[4].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[4].Hand[4].CardRank = Rank.Ten;
            PokerHandArray[4].Hand[4].CardSuit = Suit.Club;

            /***************************************************/

            PokerHandArray[5].Hand[0].CardRank = Rank.Seven;
            PokerHandArray[5].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[5].Hand[1].CardRank = Rank.Eight;
            PokerHandArray[5].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[5].Hand[2].CardRank = Rank.Nine;
            PokerHandArray[5].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[5].Hand[3].CardRank = Rank.Ten;
            PokerHandArray[5].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[5].Hand[4].CardRank = Rank.Jack;
            PokerHandArray[5].Hand[4].CardSuit = Suit.Club;

            /***************************************************/

            PokerHandArray[6].Hand[0].CardRank = Rank.Eight;
            PokerHandArray[6].Hand[0].CardSuit = Suit.Diamond;
        
            PokerHandArray[6].Hand[1].CardRank = Rank.Nine;
            PokerHandArray[6].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[6].Hand[2].CardRank = Rank.Ten;
            PokerHandArray[6].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[6].Hand[3].CardRank = Rank.Jack;
            PokerHandArray[6].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[6].Hand[4].CardRank = Rank.Queen;
            PokerHandArray[6].Hand[4].CardSuit = Suit.Club;

            /***************************************************/

            PokerHandArray[7].Hand[0].CardRank = Rank.King;
            PokerHandArray[7].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[7].Hand[1].CardRank = Rank.Nine;
            PokerHandArray[7].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[7].Hand[2].CardRank = Rank.Ten;
            PokerHandArray[7].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[7].Hand[3].CardRank = Rank.Jack;
            PokerHandArray[7].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[7].Hand[4].CardRank = Rank.Queen;
            PokerHandArray[7].Hand[4].CardSuit = Suit.Club;

            /***************************************************/

            PokerHandArray[8].Hand[0].CardRank = Rank.King;
            PokerHandArray[8].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[8].Hand[1].CardRank = Rank.Ace;
            PokerHandArray[8].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[8].Hand[2].CardRank = Rank.Ten;
            PokerHandArray[8].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[8].Hand[3].CardRank = Rank.Jack;
            PokerHandArray[8].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[8].Hand[4].CardRank = Rank.Queen;
            PokerHandArray[8].Hand[4].CardSuit = Suit.Club;

            //Act
            BoolArray[0] = PokerHandArray[0].IsStraight();
            BoolArray[1] = PokerHandArray[1].IsStraight();
            BoolArray[2] = PokerHandArray[2].IsStraight();
            BoolArray[3] = PokerHandArray[3].IsStraight();
            BoolArray[4] = PokerHandArray[4].IsStraight();
            BoolArray[5] = PokerHandArray[5].IsStraight();
            BoolArray[6] = PokerHandArray[6].IsStraight();
            BoolArray[7] = PokerHandArray[7].IsStraight();
            BoolArray[8] = PokerHandArray[8].IsStraight();
            BoolArray[9] = PokerHandArray[8].IsStraightFlush();

            //Assert
            Assert.IsTrue(BoolArray[0]);
            Assert.IsTrue(BoolArray[1]);
            Assert.IsTrue(BoolArray[2]);
            Assert.IsTrue(BoolArray[3]);
            Assert.IsTrue(BoolArray[4]);
            Assert.IsTrue(BoolArray[5]);
            Assert.IsTrue(BoolArray[6]);
            Assert.IsTrue(BoolArray[7]);
            Assert.IsTrue(BoolArray[8]);
            Assert.IsFalse(BoolArray[9]);

        }

        [TestMethod]
        public void TestFlush()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[4];
            bool[] BoolArray = new bool[5];

            PokerHandArray[0] = new PokerHand();
            PokerHandArray[1] = new PokerHand();
            PokerHandArray[2] = new PokerHand();
            PokerHandArray[3] = new PokerHand();

            /***************************************************/

            PokerHandArray[0].Hand[0].CardRank = Rank.Two;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[1].CardRank = Rank.Three;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[2].CardRank = Rank.Four;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[3].CardRank = Rank.Five;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[4].CardRank = Rank.Six;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Club;

            /***************************************************/

            PokerHandArray[1].Hand[0].CardRank = Rank.Three;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[1].CardRank = Rank.Six;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[2].CardRank = Rank.Seven;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[3].CardRank = Rank.Queen;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[4].CardRank = Rank.King;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Heart;

            /***************************************************/

            PokerHandArray[2].Hand[0].CardRank = Rank.Two;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[1].CardRank = Rank.Four;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[2].CardRank = Rank.Six;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[3].CardRank = Rank.Ten;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[4].CardRank = Rank.Jack;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Diamond;

            /***************************************************/

            PokerHandArray[3].Hand[0].CardRank = Rank.Four;
            PokerHandArray[3].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[3].Hand[1].CardRank = Rank.Nine;
            PokerHandArray[3].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[3].Hand[2].CardRank = Rank.Ten;
            PokerHandArray[3].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[3].Hand[3].CardRank = Rank.Jack;
            PokerHandArray[3].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[3].Hand[4].CardRank = Rank.Queen;
            PokerHandArray[3].Hand[4].CardSuit = Suit.Spade;

            //Act
            BoolArray[0] = PokerHandArray[0].IsFlush();
            BoolArray[1] = PokerHandArray[1].IsFlush();
            BoolArray[2] = PokerHandArray[2].IsFlush();
            BoolArray[3] = PokerHandArray[3].IsFlush();
            BoolArray[4] = PokerHandArray[3].IsStraightFlush();

            //Assert
            Assert.IsTrue(BoolArray[0]);
            Assert.IsTrue(BoolArray[1]);
            Assert.IsTrue(BoolArray[2]);
            Assert.IsTrue(BoolArray[3]);
            Assert.IsFalse(BoolArray[4]);
        }

        [TestMethod]
        public void TestFullHouse()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[3];
            bool[] BoolArray = new bool[4];

            PokerHandArray[0] = new PokerHand();
            PokerHandArray[1] = new PokerHand();
            PokerHandArray[2] = new PokerHand();

            /***************************************************/

            PokerHandArray[0].Hand[0].CardRank = Rank.Ten;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[1].CardRank = Rank.Ten;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[0].Hand[2].CardRank = Rank.Three;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Diamond;

            PokerHandArray[0].Hand[3].CardRank = Rank.Three;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[4].CardRank = Rank.Three;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Heart;

            /***************************************************/

            PokerHandArray[1].Hand[0].CardRank = Rank.Jack;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[1].Hand[1].CardRank = Rank.King;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[1].Hand[2].CardRank = Rank.Jack;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[1].Hand[3].CardRank = Rank.King;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[4].CardRank = Rank.Jack;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Heart;

            /***************************************************/

            PokerHandArray[2].Hand[0].CardRank = Rank.Five;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[1].CardRank = Rank.Five;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Club;

            PokerHandArray[2].Hand[2].CardRank = Rank.Five;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[2].Hand[3].CardRank = Rank.Nine;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[4].CardRank = Rank.Nine;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Diamond;

            //Act
            BoolArray[0] = PokerHandArray[0].IsFullHouse();
            BoolArray[1] = PokerHandArray[1].IsFullHouse();
            BoolArray[2] = PokerHandArray[2].IsFullHouse();
            BoolArray[3] = PokerHandArray[2].IsTwoPair();

            //Assert
            Assert.IsTrue(BoolArray[0]);
            Assert.IsTrue(BoolArray[1]);
            Assert.IsTrue(BoolArray[2]);
            Assert.IsFalse(BoolArray[3]);
        }

        [TestMethod]
        public void TestFourOfAKind()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[3];
            bool[] BoolArray = new bool[4];

            PokerHandArray[0] = new PokerHand();
            PokerHandArray[1] = new PokerHand();
            PokerHandArray[2] = new PokerHand();

            /***************************************************/

            PokerHandArray[0].Hand[0].CardRank = Rank.Ace;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Diamond;

            PokerHandArray[0].Hand[1].CardRank = Rank.Ace;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[2].CardRank = Rank.Eight;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[3].CardRank = Rank.Ace;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[0].Hand[4].CardRank = Rank.Ace;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Spade;

            /***************************************************/

            PokerHandArray[1].Hand[0].CardRank = Rank.Two;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[1].Hand[1].CardRank = Rank.Two;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[2].CardRank = Rank.Two;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[1].Hand[3].CardRank = Rank.Two;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Diamond;

            PokerHandArray[1].Hand[4].CardRank = Rank.Five;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Club;

            /***************************************************/

            PokerHandArray[2].Hand[0].CardRank = Rank.Three;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[1].CardRank = Rank.Three;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Diamond;

            PokerHandArray[2].Hand[2].CardRank = Rank.Three;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[2].Hand[3].CardRank = Rank.Three;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[2].Hand[4].CardRank = Rank.Ten;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Club;

            //Act
            BoolArray[0] = PokerHandArray[0].IsFourOfAKind();
            BoolArray[1] = PokerHandArray[1].IsFourOfAKind();
            BoolArray[2] = PokerHandArray[2].IsFourOfAKind();
            BoolArray[3] = PokerHandArray[2].IsThreeOfAKind();

            //Assert
            Assert.IsTrue(BoolArray[0]);
            Assert.IsTrue(BoolArray[1]);
            Assert.IsTrue(BoolArray[2]);
            Assert.IsFalse(BoolArray[3]);
        }

        [TestMethod]
        public void TestStraightFlush()
        {
            //Arrange
            PokerHand[] PokerHandArray = new PokerHand[3];
            bool[] BoolArray = new bool[5];

            PokerHandArray[0] = new PokerHand();
            PokerHandArray[1] = new PokerHand();
            PokerHandArray[2] = new PokerHand();

            /***************************************************/

            PokerHandArray[0].Hand[0].CardRank = Rank.Jack;
            PokerHandArray[0].Hand[0].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[1].CardRank = Rank.Ten;
            PokerHandArray[0].Hand[1].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[2].CardRank = Rank.Nine;
            PokerHandArray[0].Hand[2].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[3].CardRank = Rank.Eight;
            PokerHandArray[0].Hand[3].CardSuit = Suit.Club;

            PokerHandArray[0].Hand[4].CardRank = Rank.Seven;
            PokerHandArray[0].Hand[4].CardSuit = Suit.Club;

            /***************************************************/

            PokerHandArray[1].Hand[0].CardRank = Rank.Queen;
            PokerHandArray[1].Hand[0].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[1].CardRank = Rank.Jack;
            PokerHandArray[1].Hand[1].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[2].CardRank = Rank.Ten;
            PokerHandArray[1].Hand[2].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[3].CardRank = Rank.Nine;
            PokerHandArray[1].Hand[3].CardSuit = Suit.Heart;

            PokerHandArray[1].Hand[4].CardRank = Rank.Eight;
            PokerHandArray[1].Hand[4].CardSuit = Suit.Heart;

            /***************************************************/

            PokerHandArray[2].Hand[0].CardRank = Rank.Six;
            PokerHandArray[2].Hand[0].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[1].CardRank = Rank.Five;
            PokerHandArray[2].Hand[1].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[2].CardRank = Rank.Four;
            PokerHandArray[2].Hand[2].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[3].CardRank = Rank.Three;
            PokerHandArray[2].Hand[3].CardSuit = Suit.Spade;

            PokerHandArray[2].Hand[4].CardRank = Rank.Two;
            PokerHandArray[2].Hand[4].CardSuit = Suit.Spade;

            //Act
            BoolArray[0] = PokerHandArray[0].IsStraightFlush();
            BoolArray[1] = PokerHandArray[1].IsStraightFlush();
            BoolArray[2] = PokerHandArray[2].IsStraightFlush();
            BoolArray[3] = PokerHandArray[2].IsFlush();
            BoolArray[4] = PokerHandArray[2].IsStraight();

            //Assert
            Assert.IsTrue(BoolArray[0]);
            Assert.IsTrue(BoolArray[1]);
            Assert.IsTrue(BoolArray[2]);
        }
    }
}