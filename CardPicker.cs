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
    public partial class CardPicker : UserControl
    {
        public CardPicker()
        {
            InitializeComponent();
        }

        private void cboValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        internal void ClearSelection()
        {
            cboSuit.SelectedIndex = -1;
            cboValue.SelectedIndex = -1;
        }

        internal void SelectRandom()
        {
            cboSuit.SelectedIndex = Form1.random.Next(cboSuit.Items.Count);
            cboValue.SelectedIndex = Form1.random.Next(cboValue.Items.Count);
        }

        internal int SelectedValueIndex
        {
            get { return cboValue.SelectedIndex; }
        }

        internal int SelectedSuitIndex
        {
            get { return cboSuit.SelectedIndex; }
        }

        internal void SetCard(Card card)
        {
            cboSuit.SelectedIndex = (int)card.Suit;
            cboValue.SelectedIndex = card.Value - 1;
        }
    }
}
