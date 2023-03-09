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
        //public static List<Card> secondHalfOfPack = new List<Card>(); //for riffle shuffle
        public static List<Card> dealtCards = new List<Card>();
        

        //Card[] deckOfCards;

        public Pack() //constructor for pack
        {
            //int[] suitList = {1,2,3,4};
            //int[] valueList = {1,2,3,4,5,6,7,8,9,10,11,12,13};
             //integers rather than list
          
            
            for (int i = 1; i <= 4;i++) //suits 1-4
            {
                for (int j = 1; j <= 13;j++) //values 1-13
                {
                    pack.Add(new Card(j,i)); //append the created card to list pack
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
                /*
                starts at top of pack (counter)
                generate random number within range of number of cards in pack
                swap counter element and random element
                return true
                */

                Random rnd = new Random();
                
                int packPointer = 0; //array index begins at 0
                
                while (packPointer != pack.Count-1)
                {
                    //generating random integer (0-51) for a random list index
                    int randomInt = rnd.Next(0,pack.Count); //elements of array is 1 greater than array index so it is 0-51
                    
                    //swapping element positions
                    Card temp = pack[packPointer]; //temp value
                    pack[packPointer] = pack[randomInt];
                    pack[randomInt] = temp;

                    //increment pointer
                    packPointer = packPointer + 1; 
                }
                return true;
            
            }
            else if (typeOfShuffle == 2) //Riffle shuffle
            {
                /*
                split the pack into two halves
                while pointer is not the length of both packs, alternate between the two halves and add the top card to pack
                when done return true
                */

                //first half index: 0-26, doesn't include 26th element
                //second half index: 26-52
                //int rifflePointer1 = 0; //pointer for first half
                //int rifflePointer2 = 26; //pointer for second half

                //splitting the pack into two halves

                Console.WriteLine("running riffler shuffle");
                int i = 0;
                while (i < (pack.Count / 2))
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
                pack.RemoveAt(0); //removes the card from the pack
                //Console.WriteLine("Dealing card: ", toDeal);
                return toDeal;
            }
        }
        public static List<Card> dealCard(int amount)
        {
            //deals the number of cards specified by amount
            if (pack.Count == 0) //case for empty pack
            {
                Console.WriteLine($"The pack of cards is empty, cannot deal {amount} cards.");
                return null;
            }
            else if (pack.Count < amount) //condition for not enough cards to draw given amount
            {
                Console.WriteLine($"You want to draw {amount} cards but there are only {pack.Count} cards remaining.");
                Console.WriteLine("Try a different amount of cards to deal");
                return null;
            }
            else
            {
                //getting cards from top of the pack for specified amount of times
                for (int i = 0; i < amount; i++)
                {
                    dealtCards.Add(dealCard());
                    //dealtCard.Clear(); //empties the array
                    //Card topCard = pack[0];
                    //pack.RemoveAt(0);
                    //dealtCard.Add(topCard); //removes the card from the pack
                    //.AddRange(dealtCard);
                   // return topCard;
                    //pack.RemoveAt(0); 

                    //dealtCard.Add(topCard);
                    
                }
                return dealtCards;
            }
        }

        public static void outputPack()
        {
            foreach (Card cardToOutput in pack)
            {
                cardToOutput.outputCard();
            }
        }
    }
}