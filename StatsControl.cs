using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
** Dan Brecht - 2019
** https://github.com/danbrecht
*/

namespace CribbageHand
{
    internal partial class StatsControl : UserControl
    {
        HandStats handStats;
        List<Card> lstCrib;
        double dblMean;

        internal StatsControl(HandStats handStats, List<Card> lstCrib)
        {
            InitializeComponent();

            this.handStats = handStats;
            this.lstCrib = lstCrib;
            this.dblMean = handStats.CalculateMean();
        }

        private void StatsControl_Load(object sender, EventArgs e)
        {
            lblHand.Text += " ";

            foreach (Card card in handStats.StatsHand.Cards)
                lblHand.Text += card.ValueString + card.Suit.ToString().Substring(0, 1) + " ";

            lblCrib.Text += " ";

            foreach (Card card in lstCrib)
                lblCrib.Text += card.ValueString + card.Suit.ToString().Substring(0, 1) + " ";

            lblMax.Text += " " + handStats.Points.Last().Key;
            lblMin.Text += " " + handStats.Points.First().Key;
            lblMean.Text += " " + this.dblMean.ToString("0.00");

            foreach (var pair in handStats.Points.Reverse())
            {
                foreach (Card card in pair.Value)
                    lboPoints.Items.Add(card.ValueString + card.Suit.ToString().Substring(0, 1) + " - " + pair.Key);
            }
        }

        public double Mean
        {
            get { return dblMean; }
        }
    }
}
