using System;
using OOPassessment;

namespace OOPassessment
{
	public class Testing
	{
		public static void Test()
		{
            Pack packOfCards = new Pack();

            Console.WriteLine("initial pack:");
            Pack.outputPack(); //outputs the pack
            Console.WriteLine("---------------\n");


            bool shuffleCheck1 = packOfCards.shuffleCardPack(1);
            Console.WriteLine("fisher yates shuffle: " + shuffleCheck1);
            Pack.outputPack(); //outputs the shuffled pack
            Console.WriteLine("---------------\n");

            bool shuffleCheck2 = packOfCards.shuffleCardPack(2);
            Console.WriteLine("riffle shuffle: " + shuffleCheck2);
            Pack.outputPack();//outputs the shuffled pack
            Console.WriteLine("---------------\n");

            bool shuffleCheck3 = packOfCards.shuffleCardPack(3);
            Console.WriteLine("no shuffle: " + shuffleCheck3);
            Pack.outputPack();//pack stays the same, still shuffled from riffle shuffle
            Console.WriteLine("---------------\n");

            //deals 10 cards
            Pack.dealCard(10);
            Console.WriteLine("Cards that have been dealt\n");

            foreach (Card card in Pack.dealtCards) //outputs all dealt cards
            {
                card.outputCard();
            }

            Console.WriteLine("\nCards in pack\n"); //outputs cards remaining in the pack
            Pack.outputPack();

            Console.ReadKey(); //waits for any keyboard stroke before terminal closes
        }
	}
}

