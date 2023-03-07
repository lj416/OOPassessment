using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPassessment
{
    public class Pack
    {
        List<Card> pack = new List<Card>();
        //Card[] deckOfCards;
    
        public Pack() //constructor for pack
        {
            //int[] suitList = {1,2,3,4};
            //int[] valueList = {1,2,3,4,5,6,7,8,9,10,11,12,13};
            int suitLength = 4; //integers rather than list
            int valueLength = 13;
            
            for (int i = 0; i < suitLength; i++) //suits 1-4
            {
                for (int j = 0; j < valueLength;i++) //values 1-13
                {
                    pack.Add(new Card(i,j)); //append the created card to list pack
                }
            }
            
            
        }

        public static Card deal()
        {//last
            //deals one card
            
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //shuffles the card pack based on the type of shuffle
            //1: Fisher-Yates Shuffle  2: Riffle Shuffle  3: No Shuffle
            
            if (typeofShuffle = 1) //Fisher-Yates shuffle
            {
                /*
                starts at top of pack (counter)
                generate random number within range of number of cards in pack
                swap counter element and random element
                return true
                */

                Random rnd = new Random();
                
                int packPointer = 0; //array index begins at 0
                
                while (packPointer != pack.Length)
                {
                    //generating random integer (0-51) for a random list index
                    int randomInt = rnd.Next(0,pack.Length); //length of array is 1 greater than array index so it is 0-51
                    
                    //swapping element positions
                    Card temp = pack[packPointer]; //temp value
                    pack[packPointer] = pack[randomInt];
                    pack[randomInt] = temp;

                    //increment pointer
                    packPointer = packPointer + 1; 
                }
                return true;
            
            }
            else if (typeOfShuffle = 2) //Riffle shuffle
            {
                /*
                split the pack into two halves
                while counter is not the length of both packs, alternate between the two halves and add the top card to pack
                when done return true
                */

                //first half index: 0-26, doesn't include 26th element
                //second half index: 26-52

                return true;

            }
            else if (typeOfShuffle = 3) //3 No shuffle 
            {
                System.Console.WriteLine("The card pack stays as it is.");
                return true;
            }
            else
                System.Console.WriteLine("Invalid, value must be 1-3.");
        }


        public static List<Card> dealCard(int amount)
        {
            //deals the number of cards specified by amount
          
        }
    }
}