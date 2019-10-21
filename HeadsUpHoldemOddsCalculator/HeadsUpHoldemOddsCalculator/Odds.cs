using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsUpHoldemOddsCalculator
{
    public struct Odds
    {
        public double Win;
        public double Lose;
        public double Draw;

        public Odds(double Win, double Lose, double Draw)
        {
            this.Win = Win;
            this.Lose = Lose;
            this.Draw = Draw;
        }
    }
}