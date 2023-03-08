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
        public static List<Card> secondHalfOfPack = new List<Card>(); //for riffle shuffle
        public static List<Card> dealtCard = new List<Card>();

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
            System.Console.WriteLine($"AMOUNT OF CARDS IN PACK {pack.Count}."); //expect 52 cards
            
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
                while pointer is not the length of both packs, alternate between the two halves and add the top card to pack
                when done return true
                */

                //first half index: 0-26, doesn't include 26th element
                //second half index: 26-52
                int rifflePointer1 = 0; //pointer for first half
                int rifflePointer2 = 26; //pointer for second half

                //splitting the pack into two halves
                firstHalfOfPack.AddRange(pack.GetRange(0,26)); //goes up to 25
                secondHalfOfPack.AddRange(pack.GetRange(26,52)); //26-51

                while (rifflePointer1 < 26 && rifflePointer2 < 52)
                {
                    pack[rifflePointer1] = firstHalfOfPack[rifflePointer1]; 

                    rifflePointer1 = rifflePointer1 + 1; //increment first pointer for value from second half of pack

                    pack[rifflePointer1] = secondHalfOfPack[rifflePointer2];

                    rifflePointer1 = rifflePointer1 + 1;
                    rifflePointer2 = rifflePointer2 + 1;
                }

                return true;

            }
            else if (typeOfShuffle = 3) //3 No shuffle 
            {
                System.Console.WriteLine("The card pack stays as it is.");
                return false;
            }
            else
                System.Console.WriteLine("Invalid, value must be 1-3.");
        }

        public static Card deal()
        {
            //deals one card
            dealtCard.Clear(); //empty array for each time deal method is run

            if (pack.Count = 0) //if there are no cards
            {
                System.Console.WriteLine("The pack of cards is empty.");
                return null;
            }
            else
            {
                Card toDeal = pack(pack.Last());
                pack.RemoveAt(pack.Last()); //removes the card from the pack

                dealtCard.Add(toDeal);
                return toDeal;
            }
        }
        public static List<Card> dealCard(int amount)
        {
            //deals the number of cards specified by amount
            if (pack.Count = 0) //case for empty pack
            {
                System.Console.WriteLine($"The pack of cards is empty, cannot deal {amount} cards.");
                return null;
            }
            else if (pack.Count < amount) //condition for not enough cards to draw given amount
            {
                System.Console.WriteLine($"You want to draw {amount} cards but there are only {pack.Count} cards remaining.");
                System.Console.WriteLine("Try a different amount of cards to deal");
                return null;
            }
            else
            {
                //getting cards from top of the pack for specified amount of times
                for (int i = 0; i < amount; i++)
                {
                    dealtCard.Clear(); //empties the array

                    Card toDeal = pack(pack.Last());
                    pack.RemoveAt(pack.Last()); //removes the card from the pack

                    dealtCard.Add(toDeal);
                    return dealtCard; //consists of multiple cards rather than just one
                }
            }
        }

        public void outputPack()
        {
            Card cardToOutput;
            for (int i = 0; i < pack.Count; i++) //for a full pack, pack.Count should be 52. pack index ends at 51 for 52 cards
            {
                cardToOutput.outputCard();
            }
        }
    }
}