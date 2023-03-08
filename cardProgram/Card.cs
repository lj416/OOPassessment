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

        public int Value
        {
            get
            {
                return cardValue;
            }
            set
            {
                if (cardValue > 1 && cardValue <14)
                {
                    cardValue = value;
                }
                else
                {
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
                if (cardSuit > 1 && cardSuit < 5)
                {
                    cardSuit = suit;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Suit value must be between 1-4.");
                }
            }
        }
        public Card(int value, int Suit) //constructor for card
        {
            Value = value;
            Suit = suit;
        }

        public void outputCard()
        {
            string[] stringSuit = {"Hearts","Spades","Diamonds","Clubs"}; //hearts = 0, clubs = 3
            string[] stringValue = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"}; //ace = 0, king = 12

            //output the name of the given card
            System.Console.WriteLine(stringValue[Value-1]," of ",stringSuit[Suit-1]);

        }
    }

    
}
