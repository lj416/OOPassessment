using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPassessment
{
    public class Pack
    {
        List<Card> pack;
        Card[] deckOfCards;
        public Pack()
        {
            int[] suitList = {1,2,3,4};
            int[] valueList = {1,2,3,4,5,6,7,8,9,10,11,12,13};

            for (int i = 0; i < suitList.Length; i++)
            {
                for (int j = 0; j < valueList.Length;i++)
                {

                }
            }
            
        }

        public static Card deal()
        {
            //deals one card
            
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //shuffles the card pack based on the type of shuffle
            //1: Fisher-Yates Shuffle  2: Riffle Shuffle  3: No Shuffle
            if (typeofShuffle = 1)
            {

            }
            else if (typeOfShuffle = 2)
            {

            }
            else if (typeOfShuffle = 3)
            {

            }
            else
                System.Console.WriteLine("Invalid.");
        }


        public static List<Card> dealCard(int amount)
        {
            //deals the number of cards specified by amount
          
        }
    }
}