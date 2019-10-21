using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadsUpHoldemOddsCalculator
{
    public partial class Form1 : Form
    {
        private Player User;
        private Player Computer;
        private PokerHand SharedCards;
        private Dealer CardDealer;
        private bool FirstDeal;
        private int Pot;

        public Form1()
        {
            InitializeComponent();
            ComputerActionLabel.Text = String.Empty;
            ResultLabel.Text = String.Empty;
            PotLabel.Text = String.Empty;
            ComputersCard1.Image = Properties.Resources.greenbackground;
            ComputersCard2.Image = Properties.Resources.greenbackground;
            PlayersCard1.Image = Properties.Resources.greenbackground;
            PlayersCard2.Image = Properties.Resources.greenbackground;
            SharedCard1.Image = Properties.Resources.greenbackground;
            SharedCard2.Image = Properties.Resources.greenbackground;
            SharedCard3.Image = Properties.Resources.greenbackground;
            SharedCard4.Image = Properties.Resources.greenbackground;
            SharedCard5.Image = Properties.Resources.greenbackground;

            User = new Player();
            Computer = new Player();
            SharedCards = new PokerHand();
            CardDealer = new Dealer();
            FirstDeal = true;
            Pot = 0;
        }

        private Bitmap GetCardImage(Card Card)
        {
            if (Card.CardRank == Rank.Two && Card.CardSuit == Suit.Club)
            {
                return Properties.Resources.two_club;
            }

            else if (Card.CardRank == Rank.Three && Card.CardSuit == Suit.Club)
            {
                return Properties.Resources.three_club;
            }

            else if (Card.CardRank == Rank.Four && Card.CardSuit == Suit.Club)
            {
                return Properties.Resources.four_club;
            }

            else if (Card.CardRank == Rank.Five && Card.CardSuit == Suit.Club)
            {
                return Properties.Resources.five_club;
            }

            else if (Card.CardRank == Rank.Six && Card.CardSuit == Suit.Club)
            {
                return Properties.Resources.six_club;
            }

            else if (Card.CardRank == Rank.Seven && Card.CardSuit == Suit.Club)
            {
                return Properties.Resources.seven_club;
            }

            else if (Card.CardRank == Rank.Eight && Card.CardSuit == Suit.Club)
            {
                return Properties.Resources.eight_club;
            }

            else if (Card.CardRank == Rank.Nine && Card.CardSuit == Suit.Club)
            {
                return Properties.Resources.nine_club;
            }

            else if (Card.CardRank == Rank.Ten && Card.CardSuit == Suit.Club)
            {
                return Properties.Resources.ten_club;
            }

            else if (Card.CardRank == Rank.Jack && Card.CardSuit == Suit.Club)
            {
                return Properties.Resources.jack_club;
            }

            else if (Card.CardRank == Rank.Queen && Card.CardSuit == Suit.Club)
            {
                return Properties.Resources.queen_club;
            }

            else if (Card.CardRank == Rank.King && Card.CardSuit == Suit.Club)
            {
                return Properties.Resources.king_club;
            }

            else if (Card.CardRank == Rank.Ace && Card.CardSuit == Suit.Club)
            {
                return Properties.Resources.ace_clubs;
            }

            else if (Card.CardRank == Rank.Two && Card.CardSuit == Suit.Spade)
            {
                return Properties.Resources.two_spade;
            }

            else if (Card.CardRank == Rank.Three && Card.CardSuit == Suit.Spade)
            {
                return Properties.Resources.three_spade;
            }

            else if (Card.CardRank == Rank.Four && Card.CardSuit == Suit.Spade)
            {
                return Properties.Resources.four_spade;
            }

            else if (Card.CardRank == Rank.Five && Card.CardSuit == Suit.Spade)
            {
                return Properties.Resources.five_spade;
            }

            else if (Card.CardRank == Rank.Six && Card.CardSuit == Suit.Spade)
            {
                return Properties.Resources.six_spade;
            }

            else if (Card.CardRank == Rank.Seven && Card.CardSuit == Suit.Spade)
            {
                return Properties.Resources.seven_spade;
            }

            else if (Card.CardRank == Rank.Eight && Card.CardSuit == Suit.Spade)
            {
                return Properties.Resources.eight_spade;
            }

            else if (Card.CardRank == Rank.Nine && Card.CardSuit == Suit.Spade)
            {
                return Properties.Resources.nine_spade;
            }

            else if (Card.CardRank == Rank.Ten && Card.CardSuit == Suit.Spade)
            {
                return Properties.Resources.ten_spade;
            }

            else if (Card.CardRank == Rank.Jack && Card.CardSuit == Suit.Spade)
            {
                return Properties.Resources.jack_spade;
            }

            else if (Card.CardRank == Rank.Queen && Card.CardSuit == Suit.Spade)
            {
                return Properties.Resources.queen_spade;
            }

            else if (Card.CardRank == Rank.King && Card.CardSuit == Suit.Spade)
            {
                return Properties.Resources.king_spade;
            }

            else if (Card.CardRank == Rank.Ace && Card.CardSuit == Suit.Spade)
            {
                return Properties.Resources.ace_spade;
            }

            else if (Card.CardRank == Rank.Two && Card.CardSuit == Suit.Heart)
            {
                return Properties.Resources.two_heart;
            }

            else if (Card.CardRank == Rank.Three && Card.CardSuit == Suit.Heart)
            {
                return Properties.Resources.three_heart;
            }

            else if (Card.CardRank == Rank.Four && Card.CardSuit == Suit.Heart)
            {
                return Properties.Resources.four_heart;
            }

            else if (Card.CardRank == Rank.Five && Card.CardSuit == Suit.Heart)
            {
                return Properties.Resources.five_heart;
            }

            else if (Card.CardRank == Rank.Six && Card.CardSuit == Suit.Heart)
            {
                return Properties.Resources.six_heart;
            }

            else if (Card.CardRank == Rank.Seven && Card.CardSuit == Suit.Heart)
            {
                return Properties.Resources.seven_heart;
            }

            else if (Card.CardRank == Rank.Eight && Card.CardSuit == Suit.Heart)
            {
                return Properties.Resources.eight_heart;
            }

            else if (Card.CardRank == Rank.Nine && Card.CardSuit == Suit.Heart)
            {
                return Properties.Resources.nine_heart;
            }

            else if (Card.CardRank == Rank.Ten && Card.CardSuit == Suit.Heart)
            {
                return Properties.Resources.ten_heart;
            }

            else if (Card.CardRank == Rank.Jack && Card.CardSuit == Suit.Heart)
            {
                return Properties.Resources.jack_heart;
            }

            else if (Card.CardRank == Rank.Queen && Card.CardSuit == Suit.Heart)
            {
                return Properties.Resources.queen_heart;
            }

            else if (Card.CardRank == Rank.King && Card.CardSuit == Suit.Heart)
            {
                return Properties.Resources.king_heart;
            }

            else if (Card.CardRank == Rank.Ace && Card.CardSuit == Suit.Heart)
            {
                return Properties.Resources.ace_heart;
            }

            else if (Card.CardRank == Rank.Two && Card.CardSuit == Suit.Diamond)
            {
                return Properties.Resources.two_diamond;
            }

            else if (Card.CardRank == Rank.Three && Card.CardSuit == Suit.Diamond)
            {
                return Properties.Resources.three_diamond;
            }

            else if (Card.CardRank == Rank.Four && Card.CardSuit == Suit.Diamond)
            {
                return Properties.Resources.four_diamond;
            }

            else if (Card.CardRank == Rank.Five && Card.CardSuit == Suit.Diamond)
            {
                return Properties.Resources.five_diamond;
            }

            else if (Card.CardRank == Rank.Six && Card.CardSuit == Suit.Diamond)
            {
                return Properties.Resources.six_diamond;
            }

            else if (Card.CardRank == Rank.Seven && Card.CardSuit == Suit.Diamond)
            {
                return Properties.Resources.seven_diamond;
            }

            else if (Card.CardRank == Rank.Eight && Card.CardSuit == Suit.Diamond)
            {
                return Properties.Resources.eight_diamond;
            }

            else if (Card.CardRank == Rank.Nine && Card.CardSuit == Suit.Diamond)
            {
                return Properties.Resources.nine_diamond;
            }

            else if (Card.CardRank == Rank.Ten && Card.CardSuit == Suit.Diamond)
            {
                return Properties.Resources.ten_diamond;
            }

            else if (Card.CardRank == Rank.Jack && Card.CardSuit == Suit.Diamond)
            {
                return Properties.Resources.jack_diamond;
            }

            else if (Card.CardRank == Rank.Queen && Card.CardSuit == Suit.Diamond)
            {
                return Properties.Resources.queen_diamond;
            }

            else if (Card.CardRank == Rank.King && Card.CardSuit == Suit.Diamond)
            {
                return Properties.Resources.king_diamond;
            }

            else
            {
                return Properties.Resources.ace_diamond;
            }
        }

        private void DealHandButton_Click(object sender, EventArgs e)
        {
            string ChanceOfWinning, ChanceOfLosing, ChanceOfDrawing;

            if (FirstDeal)
            {
                DealButton.Text = "Deal Next Hand";
                FirstDeal = false;
            }

            else
            {
                ResultLabel.Text = String.Empty;
                ComputerActionLabel.Text = String.Empty;
                CardDealer.ResetDeck();
            }

            User.Money -= 10;
            Computer.Money -= 10;
            Pot += 20;

            CardDealer.Deal(User, Computer, SharedCards);
            Odds UsersOdds = User.HoldemHand.CalculateOdds(SharedCards);

            ChanceOfWinning = (Math.Round(UsersOdds.Win, 2)).ToString();
            ChanceOfLosing = (Math.Round(UsersOdds.Lose, 2)).ToString();
            ChanceOfDrawing = (Math.Round(UsersOdds.Draw, 2)).ToString();

            PlayersOddsLabel.Text = $"Win: {ChanceOfWinning}%\nLose: {ChanceOfLosing}%\n"
                               + $"Draw: {ChanceOfDrawing}%";

            PotLabel.Text = $"Pot: ${Pot}";

            ComputersCard1.Image = Properties.Resources.backsideofcard;
            ComputersCard2.Image = Properties.Resources.backsideofcard;

            PlayersCard1.Image = GetCardImage(User.HoldemHand.Hand[0]);
            PlayersCard2.Image = GetCardImage(User.HoldemHand.Hand[1]);

            SharedCard1.Image = GetCardImage(SharedCards.Hand[0]);
            SharedCard2.Image = GetCardImage(SharedCards.Hand[1]);
            SharedCard3.Image = GetCardImage(SharedCards.Hand[2]);
            SharedCard4.Image = GetCardImage(SharedCards.Hand[3]);
            SharedCard5.Image = GetCardImage(SharedCards.Hand[4]);

            ComputerMoneyLabel.Text = $"${Computer.Money}";
            PlayerMoneyLabel.Text = $"${User.Money}";

            DealButton.Enabled = false;
            FoldButton.Enabled = true;

            if (User.Money != 0)
            {
                RaiseButton.Enabled = true;
            }
        }

        private void PlayerLoses()
        {
            ComputerActionLabel.Visible = false;
            ResultLabel.Visible = false;
            PotLabel.Visible = false;
            ComputersCard1.Visible = false;
            ComputersCard2.Visible = false;
            PlayersCard1.Visible = false;
            PlayersCard2.Visible = false;
            SharedCard1.Visible = false;
            SharedCard2.Visible = false;
            SharedCard3.Visible = false;
            SharedCard4.Visible = false;
            SharedCard5.Visible = false;
            PlayerMoneyLabel.Visible = false;
            DealButton.Visible = false;
            RaiseButton.Visible = false;
            FoldButton.Visible = false;
            PlayersOddsLabel.Visible = false;
            ComputerMoneyLabel.Visible = false;

            BackgroundImage = Properties.Resources.playerloses;
        }

        private void PlayerWins()
        {
            ComputerActionLabel.Visible = false;
            ResultLabel.Visible = false;
            PotLabel.Visible = false;
            ComputersCard1.Visible = false;
            ComputersCard2.Visible = false;
            PlayersCard1.Visible = false;
            PlayersCard2.Visible = false;
            SharedCard1.Visible = false;
            SharedCard2.Visible = false;
            SharedCard3.Visible = false;
            SharedCard4.Visible = false;
            SharedCard5.Visible = false;
            PlayerMoneyLabel.Visible = false;
            DealButton.Visible = false;
            RaiseButton.Visible = false;
            FoldButton.Visible = false;
            PlayersOddsLabel.Visible = false;
            ComputerMoneyLabel.Visible = false;

            BackgroundImage = Properties.Resources.playerswins;
        }

        private void FoldButton_Click(object sender, EventArgs e)
        {
            if (User.Money == 0)
            {
                PlayerLoses();
            }

            else
            {
                PlayersOddsLabel.Text = "Win: N/A\nLose: N/A\nDraw: N/A";

                ComputersCard1.Image = GetCardImage(Computer.HoldemHand.Hand[0]);
                ComputersCard2.Image = GetCardImage(Computer.HoldemHand.Hand[1]);

                ResultLabel.Text = "The Computer\nWins This Hand";

                Computer.Money += Pot;
                Pot = 0;

                PotLabel.Text = $"Pot: ${Pot}";
                ComputerMoneyLabel.Text = $"${Computer.Money}";

                DealButton.Enabled = true;
                FoldButton.Enabled = false;
                RaiseButton.Enabled = false;
            }
        }

        private void RaiseButton_Click(object sender, EventArgs e)
        {
            if (Computer.Money == 0) PlayerWins();

            PlayersOddsLabel.Text = "Win: N/A\nLose: N/A\nDraw: N/A";

            User.Money -= 10;
            Pot += 10;

            Odds ComputersOdds = Computer.HoldemHand.CalculateOdds(SharedCards);

            if (ComputersOdds.Win > 50.0)
            {
                Computer.Money -= 10;
                Pot += 10;

                PokerHand PlayersBestHand = User.HoldemHand.FindBestPokerHand(SharedCards);
                PokerHand ComputersBestHand = Computer.HoldemHand.FindBestPokerHand(SharedCards);

                int ResultOfComparision = PlayersBestHand.CompareTo(ComputersBestHand);

                if (ResultOfComparision == 1)
                {
                    if (Computer.Money == 0)
                    {
                        PlayerWins();
                    }

                    else
                    {
                        User.Money += Pot;
                        Pot = 0;
                        ComputerMoneyLabel.Text = $"${Computer.Money}";
                        ComputerActionLabel.Text = "Computer: Called";
                        ComputersCard1.Image = GetCardImage(Computer.HoldemHand.Hand[0]);
                        ComputersCard2.Image = GetCardImage(Computer.HoldemHand.Hand[1]);
                        PotLabel.Text = $"Pot: ${Pot}";
                        DealButton.Enabled = true;
                        FoldButton.Enabled = false;
                        RaiseButton.Enabled = false;
                        ResultLabel.Text = "You Win\nThis Hand!";
                        PlayerMoneyLabel.Text = $"${User.Money}";
                    }
                }

                else if (ResultOfComparision == -1)
                {
                    if (User.Money == 0)
                    {
                        PlayerLoses();
                    }

                    else
                    {
                        Computer.Money += Pot;
                        Pot = 0;
                        ComputerMoneyLabel.Text = $"${Computer.Money}";
                        ComputerActionLabel.Text = "Computer: Called";
                        ComputersCard1.Image = GetCardImage(Computer.HoldemHand.Hand[0]);
                        ComputersCard2.Image = GetCardImage(Computer.HoldemHand.Hand[1]);
                        PotLabel.Text = $"Pot: ${Pot}";
                        DealButton.Enabled = true;
                        FoldButton.Enabled = false;
                        RaiseButton.Enabled = false;
                        ResultLabel.Text = "The Computer\nWins This Hand";
                        PlayerMoneyLabel.Text = $"${User.Money}";
                    }
                }

                else
                {
                    int SplitPot = Pot / 2;
                    User.Money += 20;
                    Computer.Money += 20;
                    Pot = 0;
                    ComputerMoneyLabel.Text = $"${Computer.Money}";
                    ComputerActionLabel.Text = "Computer: Called";
                    ComputersCard1.Image = GetCardImage(Computer.HoldemHand.Hand[0]);
                    ComputersCard2.Image = GetCardImage(Computer.HoldemHand.Hand[1]);
                    PotLabel.Text = $"Pot: ${Pot}";
                    DealButton.Enabled = true;
                    FoldButton.Enabled = false;
                    RaiseButton.Enabled = false;
                    ResultLabel.Text = "It's a\nDraw!";
                    PlayerMoneyLabel.Text = $"${User.Money}";
                }
            }

            else
            {
                User.Money += Pot;
                Pot = 0;
                ComputerActionLabel.Text = "Computer: Folded";
                ComputersCard1.Image = GetCardImage(Computer.HoldemHand.Hand[0]);
                ComputersCard2.Image = GetCardImage(Computer.HoldemHand.Hand[1]);
                PotLabel.Text = $"Pot: ${Pot}";
                DealButton.Enabled = true;
                FoldButton.Enabled = false;
                RaiseButton.Enabled = false;
                ResultLabel.Text = "You Win\nThis Hand!";
                PlayerMoneyLabel.Text = $"${User.Money}";
            }
        }
    }
}