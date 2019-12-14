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
    /// Cards in players hand
    /// Also has the point calculation
    /// </summary>
    public class Hand
    {
        List<Card> lstCards;

        public Hand()
        {
            lstCards = new List<Card>();
        }

        public List<Card> Cards
        {
            get { return lstCards; }
        }

        /// <summary>
        /// Calculates the points for all of the cards in the hand
        /// </summary>
        internal int CalculatePoints()
        {
            int intPoints = 0;

            intPoints += FindRuns(lstCards);

            intPoints += FindFlushes(lstCards);

            FifteenRecursion(lstCards, 0, 0, ref intPoints);

            // pairs
            for (int i = 0; i < lstCards.Count; i++)
            {
                for (int j = i + 1; j < lstCards.Count; j++)
                {
                    if (lstCards[i].Value == lstCards[j].Value)
                        intPoints += 2;
                }
            }

            // nobs
            // first card is the cut card, ignore for nobs
            if (lstCards.First().Value != 11 && lstCards.Exists(p => p.Value == 11 && p.Suit == lstCards.First().Suit))
                intPoints++;

            return intPoints;
        }

        /// <summary>
        /// Considered a flush when original hand contains at least 4 of the same suit 
        /// </summary>
        private int FindFlushes(List<Card> lstCards)
        {
            List<Card> lstFlush;
            int intPoints = 0;

            // loop through each suit
            for (int i = 0; i < 4; i++)
            {
                // get cards that have this suit
                lstFlush = lstCards.FindAll(p => (int)p.Suit == i);

                // don't count if the cut card is needed for 4 card flush
                if (lstFlush.Count == 4 && lstFlush.Contains(lstCards.First()))
                    continue;
                // we have a flush, add the number of cards in the flush to the point count
                else if (lstFlush.Count >= 4)
                    intPoints += lstFlush.Count;
            }

            return intPoints;
        }

        /// <summary>
        /// Run consists of 3 or more cards with consecutive rank values
        /// Every card in the run is worth one point
        /// We can break it into unique consecutive card in the run and double for every duplicate
        ///  3 4 5 = 3pts
        ///  3 4 4 5 = 6pts
        ///  3 4 4 4 5 = 9pts
        ///  3 4 4 5 5 = 12pts
        /// </summary>
        private int FindRuns(List<Card> lstCards)
        {
            List<Card> lstRunCards, lstDuplicates, lstTempCards;
            int intPoints = 0;

            lstTempCards = new List<Card>();
            lstDuplicates = new List<Card>();

            // put unique point/rank cards in one list and the duplicates in another
            foreach (Card card in lstCards)
            {
                if (lstTempCards.Exists(p => p.Value == card.Value))
                    lstDuplicates.Add(card);
                else
                    lstTempCards.Add(card);
            }

            lstRunCards = new List<Card>();

            // sort unique rank cards
            lstTempCards.Sort((p1, p2) => p2.Value.CompareTo(p1.Value));

            lstRunCards.Add(lstTempCards.Last());
            lstTempCards.RemoveAt(lstTempCards.Count - 1);

            // since we allow n number of cards in the hand, it is possible there is more than one 
            // consecutive run of cards, we need to make sure we find all runs
            // i.e. 3 4 5 10 J J Q
            while (lstTempCards.Count != 0)
            {
                // next card is not in sequence, run is over, get the points
                if (lstTempCards.Last().Value - lstRunCards.Last().Value != 1)
                {
                    intPoints += CalculateRunPoints(lstRunCards, lstDuplicates);

                    lstRunCards.Clear();
                }

                // add card to run
                lstRunCards.Add(lstTempCards.Last());
                lstTempCards.RemoveAt(lstTempCards.Count - 1);
            }

            // get the last run
            intPoints += CalculateRunPoints(lstRunCards, lstDuplicates);

            return intPoints;
        }

        /// <summary>
        /// Calculate the points in the run
        /// </summary>
        private int CalculateRunPoints(List<Card> lstRunCards, List<Card> lstDuplicates)
        {
            int intCurrentSum, intSum = 0;

            // not enough cards for a run
            if (lstRunCards.Count < 3)
                return 0;

            // each card in the run is worth a point
            intSum = intCurrentSum = lstRunCards.Count;

            // check each card in the run and see if it had duplicates
            foreach (Card card in lstRunCards)
            {
                // find duplicates, every duplicate doubles the points for the run
                foreach (Card duplicate in lstDuplicates.FindAll(p => p.Value == card.Value))
                    intSum += intCurrentSum;

                intCurrentSum = intSum;
            }

            return intSum;
        }

        /// <summary>
        /// Recursive function tries every combination of cards
        /// </summary>
        private void FifteenRecursion(List<Card> lstCards, int index, int sum, ref int intPoints)
        {
            int tempSum;

            // we have run out of cards
            if (index == lstCards.Count)
                return;

            // add current card to total
            tempSum = sum + lstCards[index].PointValue;

            // recurse using this cards value
            FifteenRecursion(lstCards, index + 1, tempSum, ref intPoints);

            // recurse not using this cards value
            FifteenRecursion(lstCards, index + 1, sum, ref intPoints);

            if (tempSum == 15)
                intPoints += 2;
        }
    }
}
