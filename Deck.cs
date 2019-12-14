using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
** Dan Brecht - 2019
** https://github.com/danbrecht
*/

namespace CribbageHand
{
    /// <summary>
    /// Standard deck of cards
    /// </summary>
    public class Deck
    {
        List<Card> lstCards;

        /// <summary>
        /// Standard deck of cards
        /// </summary>
        public Deck()
        {
            lstCards = new List<Card>();

            for (int i = 1; i <= 13; i++)
            {
                for (int j = 0; j < 4; j++)
                    lstCards.Add(new Card((Card.Suits)j, i));
            }
        }

        /// <summary>
        ///  Shuffle the deck
        /// </summary>
        public void Shuffle()
        {
            List<Card> lstTemp = new List<Card>();
            int index;

            lstCards.Clear();

            // create new deck
            for (int i = 1; i <= 13; i++)
            {
                for (int j = 0; j < 4; j++)
                    lstTemp.Add(new Card((Card.Suits)j, i));
            }

            // randomly add cards from the temp list to this deck
            while (lstTemp.Count != 0)
            {
                // random index
                index = Form1.random.Next(lstTemp.Count);

                lstCards.Add(lstTemp[index]);

                lstTemp.RemoveAt(index);
            }
        }

        /// <summary>
        /// Get the specified card from the deck (removes the card)
        /// </summary>
        internal Card PullCard(int selectedValueIndex, int selectedSuitIndex)
        {
            Card card;

            card = this.lstCards.Find(p => p.Value == selectedValueIndex && p.Suit == (Card.Suits)selectedSuitIndex);

            this.lstCards.Remove(card);

            return card;
        }

        internal List<Card> Cards 
        {
            get { return lstCards; }
        }
    }
}
