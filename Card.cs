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
    /// Every card has a rank (A, 2 - 10, J, Q, K) and a suit
    /// </summary>
    public class Card
    {
        public enum Suits
        {
            Heart,
            Spade,
            Club,
            Diamond
        }

        Suits suit;
        int intValue;

        public Card(Suits suit, int intValue)
        {
            this.suit = suit;
            this.intValue = intValue;
        }

        public Suits Suit
        {
            get { return suit; }
        }

        /// <summary>
        /// Face cards are worth 10, Aces are 1
        /// </summary>
        public int PointValue
        {
            get
            {
                if (intValue > 10)
                    return 10;
                return intValue;
            }
        }

        public int Value
        {
            get { return intValue; }
        }

        /// <summary>
        /// Rank string
        /// </summary>
        public string ValueString
        {
            get
            {
                if (intValue == 1)
                    return "A";
                else if (intValue < 11)
                    return intValue.ToString();
                else
                {
                    switch (intValue)
                    {
                        case 11:
                            return "J";
                        case 12:
                            return "Q";
                        case 13:
                            return "K";
                        default:
                            throw new Exception("Unexpected card value");

                    }
                }

            }
        }
    }
}
