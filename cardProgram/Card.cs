using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPassessment
{

    public class Card
    {
        private int cardValue;
        private int cardSuit;

        readonly string[] stringSuit = { "Hearts", "Spades", "Diamonds", "Clubs" }; //hearts = 0, clubs = 3
        readonly string[] stringValue = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine","Ten", "Jack", "Queen", "King" }; //ace = 0, king = 12

        public int Value
        {
            get
            {
                return cardValue;
            }

            set
            {
                if (value >= 1 || value <= 13)
                {
                    cardValue = value;
                }
                else
                {
                    //System.Console.WriteLine("invalid value in value setter");
                    throw new ArgumentOutOfRangeException("Card value must be between 1-13");
                }
            }
        }

        public int Suit
        {
            get
            {
                return cardSuit;
            }

            set
            {
                if (value >= 1 || value <= 4)
                {
                    cardSuit = value;
                }
                else
                {
                    //System.Console.WriteLine("invalid value in suit setter");
                    throw new ArgumentOutOfRangeException("Suit value must be between 1-4."); //for the case where if condition isn't met
                }
            }
        }
        public Card(int value, int suit) //constructor for card
        {
            Value = value;
            Suit = suit;
        }

        public void outputCard()
        {


            //output the name of the given card
            Console.WriteLine(stringValue[Value-1] + " of " + stringSuit[Suit-1]);
            

        }

      

    }

    
}
