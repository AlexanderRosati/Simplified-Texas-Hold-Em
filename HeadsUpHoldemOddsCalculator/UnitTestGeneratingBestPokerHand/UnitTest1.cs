using Microsoft.VisualStudio.TestTools.UnitTesting;
using HeadsUpHoldemOddsCalculator;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestGeneratingBestPokerHand
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGeneratingBestPokerHand()
        {
            //Arrange
            HoldemHand[] HoldemHandArray = new HoldemHand[21];
            PokerHand[] PokerHandArray = new PokerHand[21];

            for (int i = 0; i < 21; ++i) HoldemHandArray[i] = new HoldemHand();
            for (int i = 0; i < 21; ++i) PokerHandArray[i] = new PokerHand();

            /***************************************/

            HoldemHandArray[0].Hand[0] = new Card(Rank.Three, Suit.Club);
            HoldemHandArray[0].Hand[1] = new Card(Rank.Three, Suit.Heart);

            PokerHandArray[0].Hand[0] = new Card(Rank.Ace, Suit.Diamond);
            PokerHandArray[0].Hand[1] = new Card(Rank.King, Suit.Diamond);
            PokerHandArray[0].Hand[2] = new Card(Rank.Jack, Suit.Heart);
            PokerHandArray[0].Hand[3] = new Card(Rank.Eight, Suit.Heart);
            PokerHandArray[0].Hand[4] = new Card(Rank.Nine, Suit.Diamond);


            HoldemHandArray[1].Hand[0] = new Card(Rank.Seven, Suit.Diamond);
            HoldemHandArray[1].Hand[1] = new Card(Rank.Four, Suit.Diamond);

            PokerHandArray[1].Hand[0] = new Card(Rank.Four, Suit.Club);
            PokerHandArray[1].Hand[1] = new Card(Rank.Seven, Suit.Spade);
            PokerHandArray[1].Hand[2] = new Card(Rank.Nine, Suit.Diamond);
            PokerHandArray[1].Hand[3] = new Card(Rank.Seven, Suit.Club);
            PokerHandArray[1].Hand[4] = new Card(Rank.Eight, Suit.Heart);


            HoldemHandArray[2].Hand[0] = new Card(Rank.King, Suit.Spade);
            HoldemHandArray[2].Hand[1] = new Card(Rank.Queen, Suit.Club);

            PokerHandArray[2].Hand[0] = new Card(Rank.Six, Suit.Club);
            PokerHandArray[2].Hand[1] = new Card(Rank.King, Suit.Diamond);
            PokerHandArray[2].Hand[2] = new Card(Rank.Jack, Suit.Club);
            PokerHandArray[2].Hand[3] = new Card(Rank.Two, Suit.Spade);
            PokerHandArray[2].Hand[4] = new Card(Rank.Six, Suit.Diamond);


            HoldemHandArray[3].Hand[0] = new Card(Rank.Seven, Suit.Club);
            HoldemHandArray[3].Hand[1] = new Card(Rank.Three, Suit.Spade);

            PokerHandArray[3].Hand[0] = new Card(Rank.Four, Suit.Heart);
            PokerHandArray[3].Hand[1] = new Card(Rank.King, Suit.Heart);
            PokerHandArray[3].Hand[2] = new Card(Rank.King, Suit.Spade);
            PokerHandArray[3].Hand[3] = new Card(Rank.Five, Suit.Heart);
            PokerHandArray[3].Hand[4] = new Card(Rank.Six, Suit.Heart);


            HoldemHandArray[4].Hand[0] = new Card(Rank.Seven, Suit.Spade);
            HoldemHandArray[4].Hand[1] = new Card(Rank.Eight, Suit.Diamond);

            PokerHandArray[4].Hand[0] = new Card(Rank.Four, Suit.Diamond);
            PokerHandArray[4].Hand[1] = new Card(Rank.Queen, Suit.Spade);
            PokerHandArray[4].Hand[2] = new Card(Rank.Five, Suit.Club);
            PokerHandArray[4].Hand[3] = new Card(Rank.King, Suit.Club);
            PokerHandArray[4].Hand[4] = new Card(Rank.Ace, Suit.Club);


            HoldemHandArray[5].Hand[0] = new Card(Rank.Two, Suit.Spade);
            HoldemHandArray[5].Hand[1] = new Card(Rank.Queen, Suit.Spade);

            PokerHandArray[5].Hand[0] = new Card(Rank.Queen, Suit.Diamond);
            PokerHandArray[5].Hand[1] = new Card(Rank.Nine, Suit.Diamond);
            PokerHandArray[5].Hand[2] = new Card(Rank.Ace, Suit.Spade);
            PokerHandArray[5].Hand[3] = new Card(Rank.Four, Suit.Spade);
            PokerHandArray[5].Hand[4] = new Card(Rank.Five, Suit.Spade);


            HoldemHandArray[6].Hand[0] = new Card(Rank.Ace, Suit.Spade);
            HoldemHandArray[6].Hand[1] = new Card(Rank.Four, Suit.Diamond);

            PokerHandArray[6].Hand[0] = new Card(Rank.King, Suit.Diamond);
            PokerHandArray[6].Hand[1] = new Card(Rank.Nine, Suit.Diamond);
            PokerHandArray[6].Hand[2] = new Card(Rank.King, Suit.Club);
            PokerHandArray[6].Hand[3] = new Card(Rank.King, Suit.Heart);
            PokerHandArray[6].Hand[4] = new Card(Rank.King, Suit.Spade);


            HoldemHandArray[7].Hand[0] = new Card(Rank.Seven, Suit.Spade);
            HoldemHandArray[7].Hand[1] = new Card(Rank.Two, Suit.Spade);

            PokerHandArray[7].Hand[0] = new Card(Rank.Three, Suit.Spade);
            PokerHandArray[7].Hand[1] = new Card(Rank.Four, Suit.Spade);
            PokerHandArray[7].Hand[2] = new Card(Rank.Five, Suit.Spade);
            PokerHandArray[7].Hand[3] = new Card(Rank.Six, Suit.Spade);
            PokerHandArray[7].Hand[4] = new Card(Rank.Eight, Suit.Spade);


            HoldemHandArray[8].Hand[0] = new Card(Rank.Three, Suit.Heart);
            HoldemHandArray[8].Hand[1] = new Card(Rank.Five, Suit.Club);

            PokerHandArray[8].Hand[0] = new Card(Rank.Three, Suit.Diamond);
            PokerHandArray[8].Hand[1] = new Card(Rank.Ten, Suit.Heart);
            PokerHandArray[8].Hand[2] = new Card(Rank.Ten, Suit.Spade);
            PokerHandArray[8].Hand[3] = new Card(Rank.Queen, Suit.Heart);
            PokerHandArray[8].Hand[4] = new Card(Rank.Queen, Suit.Diamond);


            HoldemHandArray[9].Hand[0] = new Card(Rank.Six, Suit.Diamond);
            HoldemHandArray[9].Hand[1] = new Card(Rank.Three, Suit.Heart);

            PokerHandArray[9].Hand[0] = new Card(Rank.Ten, Suit.Heart);
            PokerHandArray[9].Hand[1] = new Card(Rank.Ten, Suit.Diamond);
            PokerHandArray[9].Hand[2] = new Card(Rank.Queen, Suit.Diamond);
            PokerHandArray[9].Hand[3] = new Card(Rank.Ten, Suit.Spade);
            PokerHandArray[9].Hand[4] = new Card(Rank.Nine, Suit.Spade);


            HoldemHandArray[10].Hand[0] = new Card(Rank.Jack, Suit.Diamond);
            HoldemHandArray[10].Hand[1] = new Card(Rank.Nine, Suit.Spade);

            PokerHandArray[10].Hand[0] = new Card(Rank.Nine, Suit.Diamond);
            PokerHandArray[10].Hand[1] = new Card(Rank.Queen, Suit.Heart);
            PokerHandArray[10].Hand[2] = new Card(Rank.Queen, Suit.Diamond);
            PokerHandArray[10].Hand[3] = new Card(Rank.Queen, Suit.Spade);
            PokerHandArray[10].Hand[4] = new Card(Rank.Nine, Suit.Heart);


            HoldemHandArray[11].Hand[0] = new Card(Rank.Four, Suit.Spade);
            HoldemHandArray[11].Hand[1] = new Card(Rank.Two, Suit.Heart);

            PokerHandArray[11].Hand[0] = new Card(Rank.Four, Suit.Diamond);
            PokerHandArray[11].Hand[1] = new Card(Rank.Nine, Suit.Heart);
            PokerHandArray[11].Hand[2] = new Card(Rank.Two, Suit.Club);
            PokerHandArray[11].Hand[3] = new Card(Rank.Nine, Suit.Spade);
            PokerHandArray[11].Hand[4] = new Card(Rank.Nine, Suit.Diamond);


            HoldemHandArray[12].Hand[0] = new Card(Rank.Two, Suit.Spade);
            HoldemHandArray[12].Hand[1] = new Card(Rank.Seven, Suit.Club);

            PokerHandArray[12].Hand[0] = new Card(Rank.Five, Suit.Club);
            PokerHandArray[12].Hand[1] = new Card(Rank.Eight, Suit.Spade);
            PokerHandArray[12].Hand[2] = new Card(Rank.Three, Suit.Spade);
            PokerHandArray[12].Hand[3] = new Card(Rank.Six, Suit.Club);
            PokerHandArray[12].Hand[4] = new Card(Rank.Four, Suit.Club);


            HoldemHandArray[13].Hand[0] = new Card(Rank.King, Suit.Diamond);
            HoldemHandArray[13].Hand[1] = new Card(Rank.Jack, Suit.Club);

            PokerHandArray[13].Hand[0] = new Card(Rank.Seven, Suit.Club);
            PokerHandArray[13].Hand[1] = new Card(Rank.Two, Suit.Club);
            PokerHandArray[13].Hand[2] = new Card(Rank.Six, Suit.Diamond);
            PokerHandArray[13].Hand[3] = new Card(Rank.Three, Suit.Club);
            PokerHandArray[13].Hand[4] = new Card(Rank.Ace, Suit.Heart);


            HoldemHandArray[14].Hand[0] = new Card(Rank.Jack, Suit.Diamond);
            HoldemHandArray[14].Hand[1] = new Card(Rank.King, Suit.Diamond);

            PokerHandArray[14].Hand[0] = new Card(Rank.Ten, Suit.Diamond);
            PokerHandArray[14].Hand[1] = new Card(Rank.Six, Suit.Diamond);
            PokerHandArray[14].Hand[2] = new Card(Rank.Seven, Suit.Diamond);
            PokerHandArray[14].Hand[3] = new Card(Rank.King, Suit.Spade);
            PokerHandArray[14].Hand[4] = new Card(Rank.Nine, Suit.Diamond);


            HoldemHandArray[15].Hand[0] = new Card(Rank.Jack, Suit.Spade);
            HoldemHandArray[15].Hand[1] = new Card(Rank.Ace, Suit.Club);

            PokerHandArray[15].Hand[0] = new Card(Rank.King, Suit.Spade);
            PokerHandArray[15].Hand[1] = new Card(Rank.Ace, Suit.Spade);
            PokerHandArray[15].Hand[2] = new Card(Rank.Ace, Suit.Diamond);
            PokerHandArray[15].Hand[3] = new Card(Rank.Ace, Suit.Heart);
            PokerHandArray[15].Hand[4] = new Card(Rank.Queen, Suit.Club);


            HoldemHandArray[16].Hand[0] = new Card(Rank.Queen, Suit.Spade);
            HoldemHandArray[16].Hand[1] = new Card(Rank.Two, Suit.Spade);

            PokerHandArray[16].Hand[0] = new Card(Rank.Queen, Suit.Heart);
            PokerHandArray[16].Hand[1] = new Card(Rank.Ace, Suit.Club);
            PokerHandArray[16].Hand[2] = new Card(Rank.Ace, Suit.Heart);
            PokerHandArray[16].Hand[3] = new Card(Rank.Eight, Suit.Heart);
            PokerHandArray[16].Hand[4] = new Card(Rank.Eight, Suit.Diamond);


            HoldemHandArray[17].Hand[0] = new Card(Rank.Ace, Suit.Club);
            HoldemHandArray[17].Hand[1] = new Card(Rank.Three, Suit.Heart);

            PokerHandArray[17].Hand[0] = new Card(Rank.King, Suit.Club);
            PokerHandArray[17].Hand[1] = new Card(Rank.Queen, Suit.Club);
            PokerHandArray[17].Hand[2] = new Card(Rank.Jack, Suit.Club);
            PokerHandArray[17].Hand[3] = new Card(Rank.Six, Suit.Diamond);
            PokerHandArray[17].Hand[4] = new Card(Rank.Ten, Suit.Club);


            HoldemHandArray[18].Hand[0] = new Card(Rank.Ace, Suit.Club);
            HoldemHandArray[18].Hand[1] = new Card(Rank.Ten, Suit.Club);

            PokerHandArray[18].Hand[0] = new Card(Rank.Six, Suit.Diamond);
            PokerHandArray[18].Hand[1] = new Card(Rank.King, Suit.Club);
            PokerHandArray[18].Hand[2] = new Card(Rank.Jack, Suit.Club);
            PokerHandArray[18].Hand[3] = new Card(Rank.Three, Suit.Heart);
            PokerHandArray[18].Hand[4] = new Card(Rank.Queen, Suit.Club);


            HoldemHandArray[19].Hand[0] = new Card(Rank.Ten, Suit.Club);
            HoldemHandArray[19].Hand[1] = new Card(Rank.Ace, Suit.Club);

            PokerHandArray[19].Hand[0] = new Card(Rank.King, Suit.Club);
            PokerHandArray[19].Hand[1] = new Card(Rank.Three, Suit.Heart);
            PokerHandArray[19].Hand[2] = new Card(Rank.Queen, Suit.Club);
            PokerHandArray[19].Hand[3] = new Card(Rank.Jack, Suit.Club);
            PokerHandArray[19].Hand[4] = new Card(Rank.Six, Suit.Diamond);

            HoldemHandArray[20].Hand[0] = new Card(Rank.Three, Suit.Heart);
            HoldemHandArray[20].Hand[1] = new Card(Rank.Ace, Suit.Club);

            PokerHandArray[20].Hand[0] = new Card(Rank.Queen, Suit.Club);
            PokerHandArray[20].Hand[1] = new Card(Rank.Ten, Suit.Club);
            PokerHandArray[20].Hand[2] = new Card(Rank.Jack, Suit.Club);
            PokerHandArray[20].Hand[3] = new Card(Rank.Six, Suit.Diamond);
            PokerHandArray[20].Hand[4] = new Card(Rank.King, Suit.Club);


            //Act
            PokerHandArray[0] = HoldemHandArray[0].FindBestPokerHand(PokerHandArray[0]);
            PokerHandArray[1] = HoldemHandArray[1].FindBestPokerHand(PokerHandArray[1]);
            PokerHandArray[2] = HoldemHandArray[2].FindBestPokerHand(PokerHandArray[2]);
            PokerHandArray[3] = HoldemHandArray[3].FindBestPokerHand(PokerHandArray[3]);
            PokerHandArray[4] = HoldemHandArray[4].FindBestPokerHand(PokerHandArray[4]);
            PokerHandArray[5] = HoldemHandArray[5].FindBestPokerHand(PokerHandArray[5]);
            PokerHandArray[6] = HoldemHandArray[6].FindBestPokerHand(PokerHandArray[6]);
            PokerHandArray[7] = HoldemHandArray[7].FindBestPokerHand(PokerHandArray[7]);
            PokerHandArray[8] = HoldemHandArray[8].FindBestPokerHand(PokerHandArray[8]);
            PokerHandArray[9] = HoldemHandArray[9].FindBestPokerHand(PokerHandArray[9]);
            PokerHandArray[10] = HoldemHandArray[10].FindBestPokerHand(PokerHandArray[10]);
            PokerHandArray[11] = HoldemHandArray[11].FindBestPokerHand(PokerHandArray[11]);
            PokerHandArray[12] = HoldemHandArray[12].FindBestPokerHand(PokerHandArray[12]);
            PokerHandArray[13] = HoldemHandArray[13].FindBestPokerHand(PokerHandArray[13]);
            PokerHandArray[14] = HoldemHandArray[14].FindBestPokerHand(PokerHandArray[14]);
            PokerHandArray[15] = HoldemHandArray[15].FindBestPokerHand(PokerHandArray[15]);
            PokerHandArray[16] = HoldemHandArray[16].FindBestPokerHand(PokerHandArray[16]);
            PokerHandArray[17] = HoldemHandArray[17].FindBestPokerHand(PokerHandArray[17]);
            PokerHandArray[18] = HoldemHandArray[18].FindBestPokerHand(PokerHandArray[18]);
            PokerHandArray[19] = HoldemHandArray[19].FindBestPokerHand(PokerHandArray[19]);
            PokerHandArray[20] = HoldemHandArray[20].FindBestPokerHand(PokerHandArray[20]);

            //Assert
            Array.Sort(PokerHandArray[0].Hand);
            Array.Sort(PokerHandArray[1].Hand);
            Array.Sort(PokerHandArray[2].Hand);
            Array.Sort(PokerHandArray[3].Hand);
            Array.Sort(PokerHandArray[4].Hand);
            Array.Sort(PokerHandArray[5].Hand);
            Array.Sort(PokerHandArray[6].Hand);
            Array.Sort(PokerHandArray[7].Hand);
            Array.Sort(PokerHandArray[8].Hand);
            Array.Sort(PokerHandArray[9].Hand);
            Array.Sort(PokerHandArray[10].Hand);
            Array.Sort(PokerHandArray[11].Hand);
            Array.Sort(PokerHandArray[12].Hand);
            Array.Sort(PokerHandArray[13].Hand);
            Array.Sort(PokerHandArray[14].Hand);
            Array.Sort(PokerHandArray[15].Hand);
            Array.Sort(PokerHandArray[16].Hand);
            Array.Sort(PokerHandArray[17].Hand);
            Array.Sort(PokerHandArray[18].Hand);
            Array.Sort(PokerHandArray[19].Hand);
            Array.Sort(PokerHandArray[20].Hand);

            /***************************************/

            Assert.AreEqual(new Card(Rank.Ace, Suit.Diamond), PokerHandArray[0].Hand[0]);
            Assert.AreEqual(new Card(Rank.King, Suit.Diamond), PokerHandArray[0].Hand[1]);
            Assert.AreEqual(new Card(Rank.Jack, Suit.Heart), PokerHandArray[0].Hand[2]);
            Assert.AreEqual(new Card(Rank.Three, Suit.Club), PokerHandArray[0].Hand[3]);
            Assert.AreEqual(new Card(Rank.Three, Suit.Heart), PokerHandArray[0].Hand[4]);

            Assert.AreEqual(new Card(Rank.Seven, Suit.Diamond), PokerHandArray[1].Hand[0]);
            Assert.AreEqual(new Card(Rank.Seven, Suit.Spade), PokerHandArray[1].Hand[1]);
            Assert.AreEqual(new Card(Rank.Seven, Suit.Club), PokerHandArray[1].Hand[2]);
            Assert.AreEqual(new Card(Rank.Four, Suit.Diamond), PokerHandArray[1].Hand[3]);
            Assert.AreEqual(new Card(Rank.Four, Suit.Club), PokerHandArray[1].Hand[4]);

            Assert.AreEqual(new Card(Rank.King, Suit.Spade), PokerHandArray[2].Hand[0]);
            Assert.AreEqual(new Card(Rank.King, Suit.Diamond), PokerHandArray[2].Hand[1]);
            Assert.AreEqual(new Card(Rank.Queen, Suit.Club), PokerHandArray[2].Hand[2]);
            Assert.AreEqual(new Card(Rank.Six, Suit.Club), PokerHandArray[2].Hand[3]);
            Assert.AreEqual(new Card(Rank.Six, Suit.Diamond), PokerHandArray[2].Hand[4]);

            Assert.AreEqual(new Card(Rank.Seven, Suit.Club), PokerHandArray[3].Hand[0]);
            Assert.AreEqual(new Card(Rank.Six, Suit.Heart), PokerHandArray[3].Hand[1]);
            Assert.AreEqual(new Card(Rank.Five, Suit.Heart), PokerHandArray[3].Hand[2]);
            Assert.AreEqual(new Card(Rank.Four, Suit.Heart), PokerHandArray[3].Hand[3]);
            Assert.AreEqual(new Card(Rank.Three, Suit.Spade), PokerHandArray[3].Hand[4]);

            Assert.AreEqual(new Card(Rank.Ace, Suit.Club), PokerHandArray[4].Hand[0]);
            Assert.AreEqual(new Card(Rank.King, Suit.Club), PokerHandArray[4].Hand[1]);
            Assert.AreEqual(new Card(Rank.Queen, Suit.Spade), PokerHandArray[4].Hand[2]);
            Assert.AreEqual(new Card(Rank.Eight, Suit.Diamond), PokerHandArray[4].Hand[3]);
            Assert.AreEqual(new Card(Rank.Seven, Suit.Spade), PokerHandArray[4].Hand[4]);

            Assert.AreEqual(new Card(Rank.Ace, Suit.Spade), PokerHandArray[5].Hand[0]);
            Assert.AreEqual(new Card(Rank.Queen, Suit.Spade), PokerHandArray[5].Hand[1]);
            Assert.AreEqual(new Card(Rank.Five, Suit.Spade), PokerHandArray[5].Hand[2]);
            Assert.AreEqual(new Card(Rank.Four, Suit.Spade), PokerHandArray[5].Hand[3]);
            Assert.AreEqual(new Card(Rank.Two, Suit.Spade), PokerHandArray[5].Hand[4]);

            Assert.AreEqual(new Card(Rank.Ace, Suit.Spade), PokerHandArray[6].Hand[0]);
            Assert.AreEqual(new Card(Rank.King, Suit.Diamond), PokerHandArray[6].Hand[1]);
            Assert.AreEqual(new Card(Rank.King, Suit.Club), PokerHandArray[6].Hand[2]);
            Assert.AreEqual(new Card(Rank.King, Suit.Heart), PokerHandArray[6].Hand[3]);
            Assert.AreEqual(new Card(Rank.King, Suit.Spade), PokerHandArray[6].Hand[4]);

            Assert.AreEqual(new Card(Rank.Eight, Suit.Spade), PokerHandArray[7].Hand[0]);
            Assert.AreEqual(new Card(Rank.Seven, Suit.Spade), PokerHandArray[7].Hand[1]);
            Assert.AreEqual(new Card(Rank.Six, Suit.Spade), PokerHandArray[7].Hand[2]);
            Assert.AreEqual(new Card(Rank.Five, Suit.Spade), PokerHandArray[7].Hand[3]);
            Assert.AreEqual(new Card(Rank.Four, Suit.Spade), PokerHandArray[7].Hand[4]);

            Assert.AreEqual(new Card(Rank.Queen, Suit.Heart), PokerHandArray[8].Hand[0]);
            Assert.AreEqual(new Card(Rank.Queen, Suit.Diamond), PokerHandArray[8].Hand[1]);
            Assert.AreEqual(new Card(Rank.Ten, Suit.Heart), PokerHandArray[8].Hand[2]);
            Assert.AreEqual(new Card(Rank.Ten, Suit.Spade), PokerHandArray[8].Hand[3]);
            Assert.AreEqual(new Card(Rank.Five, Suit.Club), PokerHandArray[8].Hand[4]);

            Assert.AreEqual(new Card(Rank.Queen, Suit.Diamond), PokerHandArray[9].Hand[0]);
            Assert.AreEqual(new Card(Rank.Ten, Suit.Heart), PokerHandArray[9].Hand[1]);
            Assert.AreEqual(new Card(Rank.Ten, Suit.Diamond), PokerHandArray[9].Hand[2]);
            Assert.AreEqual(new Card(Rank.Ten, Suit.Spade), PokerHandArray[9].Hand[3]);
            Assert.AreEqual(new Card(Rank.Nine, Suit.Spade), PokerHandArray[9].Hand[4]);

            Assert.AreEqual(new Card(Rank.Queen, Suit.Heart), PokerHandArray[10].Hand[0]);
            Assert.AreEqual(new Card(Rank.Queen, Suit.Diamond), PokerHandArray[10].Hand[1]);
            Assert.AreEqual(new Card(Rank.Queen, Suit.Spade), PokerHandArray[10].Hand[2]);
            Assert.AreEqual(new Card(Rank.Nine, Suit.Spade), PokerHandArray[10].Hand[3]);
            Assert.AreEqual(new Card(Rank.Nine, Suit.Heart), PokerHandArray[10].Hand[4]);

            Assert.AreEqual(new Card(Rank.Nine, Suit.Heart), PokerHandArray[11].Hand[0]);
            Assert.AreEqual(new Card(Rank.Nine, Suit.Spade), PokerHandArray[11].Hand[1]);
            Assert.AreEqual(new Card(Rank.Nine, Suit.Diamond), PokerHandArray[11].Hand[2]);
            Assert.AreEqual(new Card(Rank.Four, Suit.Spade), PokerHandArray[11].Hand[3]);
            Assert.AreEqual(new Card(Rank.Four, Suit.Diamond), PokerHandArray[11].Hand[4]);

            Assert.AreEqual(new Card(Rank.Nine, Suit.Heart), PokerHandArray[11].Hand[0]);
            Assert.AreEqual(new Card(Rank.Nine, Suit.Spade), PokerHandArray[11].Hand[1]);
            Assert.AreEqual(new Card(Rank.Nine, Suit.Diamond), PokerHandArray[11].Hand[2]);
            Assert.AreEqual(new Card(Rank.Four, Suit.Spade), PokerHandArray[11].Hand[3]);
            Assert.AreEqual(new Card(Rank.Four, Suit.Diamond), PokerHandArray[11].Hand[4]);

            Assert.AreEqual(new Card(Rank.Eight, Suit.Spade), PokerHandArray[12].Hand[0]);
            Assert.AreEqual(new Card(Rank.Seven, Suit.Club), PokerHandArray[12].Hand[1]);
            Assert.AreEqual(new Card(Rank.Six, Suit.Club), PokerHandArray[12].Hand[2]);
            Assert.AreEqual(new Card(Rank.Five, Suit.Club), PokerHandArray[12].Hand[3]);
            Assert.AreEqual(new Card(Rank.Four, Suit.Club), PokerHandArray[12].Hand[4]);

            Assert.AreEqual(new Card(Rank.Ace, Suit.Heart), PokerHandArray[13].Hand[0]);
            Assert.AreEqual(new Card(Rank.King, Suit.Diamond), PokerHandArray[13].Hand[1]);
            Assert.AreEqual(new Card(Rank.Jack, Suit.Club), PokerHandArray[13].Hand[2]);
            Assert.AreEqual(new Card(Rank.Seven, Suit.Club), PokerHandArray[13].Hand[3]);
            Assert.AreEqual(new Card(Rank.Six, Suit.Diamond), PokerHandArray[13].Hand[4]);

            Assert.AreEqual(new Card(Rank.King, Suit.Diamond), PokerHandArray[14].Hand[0]);
            Assert.AreEqual(new Card(Rank.Jack, Suit.Diamond), PokerHandArray[14].Hand[1]);
            Assert.AreEqual(new Card(Rank.Ten, Suit.Diamond), PokerHandArray[14].Hand[2]);
            Assert.AreEqual(new Card(Rank.Nine, Suit.Diamond), PokerHandArray[14].Hand[3]);
            Assert.AreEqual(new Card(Rank.Seven, Suit.Diamond), PokerHandArray[14].Hand[4]);

            Assert.AreEqual(new Card(Rank.Ace, Suit.Club), PokerHandArray[15].Hand[0]);
            Assert.AreEqual(new Card(Rank.Ace, Suit.Spade), PokerHandArray[15].Hand[1]);
            Assert.AreEqual(new Card(Rank.Ace, Suit.Diamond), PokerHandArray[15].Hand[2]);
            Assert.AreEqual(new Card(Rank.Ace, Suit.Heart), PokerHandArray[15].Hand[3]);
            Assert.AreEqual(new Card(Rank.King, Suit.Spade), PokerHandArray[15].Hand[4]);

            Assert.AreEqual(new Card(Rank.Ace, Suit.Club), PokerHandArray[16].Hand[0]);
            Assert.AreEqual(new Card(Rank.Ace, Suit.Heart), PokerHandArray[16].Hand[1]);
            Assert.AreEqual(new Card(Rank.Queen, Suit.Spade), PokerHandArray[16].Hand[2]);
            Assert.AreEqual(new Card(Rank.Queen, Suit.Heart), PokerHandArray[16].Hand[3]);
            Assert.AreEqual(new Card(Rank.Eight, Suit.Heart), PokerHandArray[16].Hand[4]);

            Assert.AreEqual(new Card(Rank.Ace, Suit.Club), PokerHandArray[17].Hand[0]);
            Assert.AreEqual(new Card(Rank.King, Suit.Club), PokerHandArray[17].Hand[1]);
            Assert.AreEqual(new Card(Rank.Queen, Suit.Club), PokerHandArray[17].Hand[2]);
            Assert.AreEqual(new Card(Rank.Jack, Suit.Club), PokerHandArray[17].Hand[3]);
            Assert.AreEqual(new Card(Rank.Ten, Suit.Club), PokerHandArray[17].Hand[4]);

            Assert.AreEqual(new Card(Rank.Ace, Suit.Club), PokerHandArray[18].Hand[0]);
            Assert.AreEqual(new Card(Rank.King, Suit.Club), PokerHandArray[18].Hand[1]);
            Assert.AreEqual(new Card(Rank.Queen, Suit.Club), PokerHandArray[18].Hand[2]);
            Assert.AreEqual(new Card(Rank.Jack, Suit.Club), PokerHandArray[18].Hand[3]);
            Assert.AreEqual(new Card(Rank.Ten, Suit.Club), PokerHandArray[18].Hand[4]);

            Assert.AreEqual(new Card(Rank.Ace, Suit.Club), PokerHandArray[19].Hand[0]);
            Assert.AreEqual(new Card(Rank.King, Suit.Club), PokerHandArray[19].Hand[1]);
            Assert.AreEqual(new Card(Rank.Queen, Suit.Club), PokerHandArray[19].Hand[2]);
            Assert.AreEqual(new Card(Rank.Jack, Suit.Club), PokerHandArray[19].Hand[3]);
            Assert.AreEqual(new Card(Rank.Ten, Suit.Club), PokerHandArray[19].Hand[4]);

            Assert.AreEqual(new Card(Rank.Ace, Suit.Club), PokerHandArray[20].Hand[0]);
            Assert.AreEqual(new Card(Rank.King, Suit.Club), PokerHandArray[20].Hand[1]);
            Assert.AreEqual(new Card(Rank.Queen, Suit.Club), PokerHandArray[20].Hand[2]);
            Assert.AreEqual(new Card(Rank.Jack, Suit.Club), PokerHandArray[20].Hand[3]);
            Assert.AreEqual(new Card(Rank.Ten, Suit.Club), PokerHandArray[20].Hand[4]);
        }
    }
}