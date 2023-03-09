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
        readonly string[] stringValue = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" }; //ace = 0, king = 12

        public int Value
        {
            get
            {
                return cardValue;
            }

            set
            {
                if (Value >= 1 || Value <= 13)
                {
                    cardValue = Value;
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
                if (Suit >= 1 || Suit <= 4)
                {
                    cardSuit = Suit;
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
            
            Console.WriteLine(stringValue[Value] + " of " + stringSuit[Suit]);
            

        }

      

    }

    
}
