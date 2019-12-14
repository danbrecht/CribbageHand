using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
** Dan Brecht - 2019
** https://github.com/danbrecht
*/

/// <summary>
/// Takes a hand of cribbage cards and shows potential points of every card combo to send to the crib.
/// The results are ordered by the best mean point value for each hand.
/// </summary>
namespace CribbageHand
{
    public partial class Form1 : Form
    {
        // used for random hand
        public static Random random = new Random(Guid.NewGuid().GetHashCode());
        // card picker controls
        List<CardPicker> lstPickers = new List<CardPicker>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Update number of pickers displayed
        /// </summary>
        private void txtHandSize_ValueChanged(object sender, EventArgs e)
        {
            DisplayPickers();
        }

        /// <summary>
        /// Update number of card pickers to equal the hand size
        /// </summary>
        private void DisplayPickers()
        {
            int row = 18;

            // don't already have enough pickers, keep adding until we do
            while (lstPickers.Count < txtHandSize.Value)
                lstPickers.Add(new CardPicker());

            // too many pickers, keep removing
            while (lstPickers.Count > txtHandSize.Value)
            {
                gbHand.Controls.Remove(lstPickers.Last());
                lstPickers.Remove(lstPickers.Last());
            }

            // set locations and add to interface
            for (int i = 0; i < lstPickers.Count; i++, row += 25)
            {
                lstPickers[i].Location = new Point(5, row);
                gbHand.Controls.Add(lstPickers[i]);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayPickers();
        }

        /// <summary>
        /// Create random hand of cards
        /// </summary>
        private void cmdRandomHand_Click(object sender, EventArgs e)
        {
            Deck deck;

            // start with a fresh deck
            deck = new Deck();
            deck.Shuffle();

            // add cards from the 'top' of the deck
            for (int i = 0; i < lstPickers.Count; i++)
                lstPickers[i].SetCard(deck.Cards[i]);
        }

        /// <summary>
        /// Run calculation
        /// </summary>
        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            CalculateHands();
        }

        /// <summary>
        /// Calculate hand stats for every 'to crib' combination
        /// </summary>
        private void CalculateHands()
        {
            Hand mainHand;
            Deck deck;
            List<Card> lstCrib = new List<Card>();
            List<StatsControl> lstStatsControls = new List<StatsControl>();

            pnlStats.Controls.Clear();

            deck = new Deck();

            mainHand = new Hand();

            // remove the cards in the pickers from the deck and put them in the hand
            foreach (CardPicker picker in lstPickers)
                mainHand.Cards.Add(deck.PullCard(picker.SelectedValueIndex + 1, picker.SelectedSuitIndex));

            // pickers have a duplicate card
            if (mainHand.Cards.Exists(p => p == null))
            {
                MessageBox.Show("Make sure all values are filled out and there are no duplicates");
                return;
            }

            // NOTE: this is definitely not the best way to handle putting multiple cards in the crib
            // if we were going to support more than 2 I would make this more generic

            // loop through all of the cards in the hand and calculate with that card in the crib
            for (int i = 0; i < mainHand.Cards.Count; i++)
            {
                lstCrib = new List<Card>();

                lstCrib.Add(mainHand.Cards[i]);

                // if we are putting 2 cards in the crib
                if (txtToCrib.Value == 2)
                {
                    // loop through remaining cards and add that card to the crib
                    for (int j = i + 1; j < mainHand.Cards.Count; j++)
                    {
                        lstCrib = new List<Card>();

                        lstCrib.Add(mainHand.Cards[i]);

                        lstCrib.Add(mainHand.Cards[j]);

                        // calculate stats for this hand
                        lstStatsControls.Add(RunStats(mainHand, lstCrib, deck));
                    }
                }
                else
                    lstStatsControls.Add(RunStats(mainHand, lstCrib, deck));

            }

            // sort stats by descending mean point
            lstStatsControls.Sort((p2, p1) => p1.Mean.CompareTo(p2.Mean));

            // add controls to form
            for (int i = 0; i < lstStatsControls.Count; i++)
            {
                lstStatsControls[i].Location = new Point(i * (lstStatsControls[i].Width + 2), 0);
                lstStatsControls[i].Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
                pnlStats.Controls.Add(lstStatsControls[i]);
            }
        }

        /// <summary>
        /// Calculates points for all possible 'cut' cards
        /// </summary>
        private StatsControl RunStats(Hand mainHand, List<Card> lstCrib, Deck deck)
        {
            HandStats handStats;
            Hand keptHand;

            keptHand = new Hand();

            // put all the cards in the kept hand
            mainHand.Cards.ForEach(p => keptHand.Cards.Add(p));

            // remove the crib cards
            keptHand.Cards.RemoveAll(p => lstCrib.Contains(p));

            handStats = new HandStats(keptHand);

            // calculate points using each possible 'cut' card
            handStats.CalculateAllPoints(deck);

            // return control that will display the stats
            return new StatsControl(handStats, lstCrib);
        }
    }
}
