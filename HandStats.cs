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
    /// Has points for all the possible 'cut' cards
    /// </summary>
    internal class HandStats
    {
        Hand hand;
        SortedDictionary<int, List<Card>> lstPoints;

        internal HandStats(Hand hand)
        {
            this.hand = hand;
            this.lstPoints = new SortedDictionary<int, List<Card>>();
        }

        /// <summary>
        /// Calculate hand points for each cut card
        /// </summary>
        internal void CalculateAllPoints(Deck deck)
        {
            foreach (Card cutCard in deck.Cards)
                CalculatedSharedPoints(cutCard);
        }

        /// <summary>
        /// Calculate hand points
        /// </summary>
        private void CalculatedSharedPoints(Card sharedCard)
        {
            Hand tempHand;
            int intPoints;

            // create temp hand with the original hand and the cut card
            tempHand = new Hand();
            tempHand.Cards.Add(sharedCard);

            hand.Cards.ForEach(p => tempHand.Cards.Add(p));

            // get the points
            intPoints = tempHand.CalculatePoints();

            // add to list
            if (!lstPoints.ContainsKey(intPoints))
                lstPoints.Add(intPoints, new List<Card>());
            lstPoints[intPoints].Add(sharedCard);
        }

        /// <summary>
        /// Calculate average for all the possible cut cards
        /// </summary>
        internal double CalculateMean()
        {
            int intSum = 0, intCount = 0;

            foreach (var pair in lstPoints)
            {
                intSum += (pair.Key * pair.Value.Count);
                intCount += pair.Value.Count;
            }

            return (double)intSum / (double)intCount;
        }

        public Hand StatsHand
        {
            get { return hand; }
        }

        public SortedDictionary<int, List<Card>> Points
        {
            get { return lstPoints; }
        }
    }
}
