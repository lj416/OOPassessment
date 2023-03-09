using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPassessment
{
    public class Pack
    {
        public static List<Card> pack = new List<Card>(); //full pack of cards
        public static List<Card> firstHalfOfPack = new List<Card>(); //for riffle shuffle

        public static List<Card> dealtCards = new List<Card>();

        public Pack() //constructor for pack
        {
            
            for (int i = 1; i <= 4;i++) //suits 1-4
            {
                for (int j = 1; j <= 13;j++) //values 1-13
                {
                    pack.Add(new Card(j,i));  //append the created card to lsit pack
                }
            }
            System.Console.WriteLine($"AMOUNT OF CARDS IN PACK {pack.Count}."); //expect 52 cards
        }

        public bool shuffleCardPack(int typeOfShuffle)
        {
            //shuffles the card pack based on the type of shuffle
            //1: Fisher-Yates Shuffle  2: Riffle Shuffle  3: No Shuffle
            
            if (typeOfShuffle == 1) //Fisher-Yates shuffle
            {
                Random rnd = new Random();
                
                int packPointer = 0; //array index begins at 0
                
                while (packPointer != pack.Count-1) //pack.Count so that it works for any size of pack array
                {
                    //generating random integer for a random list index within the lists index values
                    int randomInt = rnd.Next(0,pack.Count); 
                    
                    //swapping element positions
                    Card temp = pack[packPointer]; //temp value
                    pack[packPointer] = pack[randomInt];
                    pack[randomInt] = temp;

                    packPointer = packPointer + 1; 
                }
                return true;
            
            }
            else if (typeOfShuffle == 2) //Riffle shuffle
            {
                int i = 0;
                while (i < (pack.Count / 2)) //gets midway point of pack
                {
                    firstHalfOfPack.Add(pack[i]);
                    firstHalfOfPack.Add(pack[i + pack.Count / 2]);
                    i++;
                }
                pack = firstHalfOfPack;
                return true;
            }
            else if (typeOfShuffle == 3) //3 No shuffle 
            {
                Console.WriteLine("The card pack stays as it is.");
                return true;
            }
            else
                Console.WriteLine("Invalid, value must be 1-3.");
                return false;
        }

        //Deals one card
        public static Card dealCard()
        {

            if (pack.Count == 0) //if there are no cards
            {
                Console.WriteLine("The pack of cards is empty.");
                return null;
            }
            else
            {
          
                Card toDeal = pack[0]; //any value at 1st element (top of the pack)
                pack.RemoveAt(0); 
                return toDeal;
            }
        }

        public static List<Card> dealCard(int amount)//deals the number of cards specified by amount
        {
            if (pack.Count == 0) 
            {
                Console.WriteLine($"The pack of cards is empty, cannot deal {amount} cards.");
                return null;
            }
            else if (pack.Count < amount) //condition for not enough cards to draw given amount
            {
                Console.WriteLine("Can't deal an amount of cards higher than what is reamining in the deck.\nTry a lower amount of cards.");
                return null;
            }
            else
            {
                //getting cards from top of the pack for specified amount of times
                for (int i = 0; i < amount; i++)
                {
                    dealtCards.Add(dealCard());
                }
                return dealtCards;
            }
        }

        public static void outputPack() //output the whole pack of cards
        { 
            foreach (Card cardToOutput in pack)
            {
                cardToOutput.outputCard();
            }
        }

        internal static void dealCard(string amountToDeal)
        {
            throw new NotImplementedException();
        }
    }
}