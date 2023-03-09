using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPassessment
{
    class Program
    {
         static void Main(string[] args)
        {
            Pack packOfCards = new Pack();
            
            
            Pack.outputPack(); //output the pack 


            bool shuffleCheck1 = packOfCards.shuffleCardPack(1);
            Console.WriteLine("fisher yates shuffle: "+shuffleCheck1);
            Pack.outputPack();
            Console.WriteLine("---------------\n");

            bool shuffleCheck2 = packOfCards.shuffleCardPack(2);
            Console.WriteLine("riffle shuffle: "+shuffleCheck2);
            Pack.outputPack();
            Console.WriteLine("---------------\n");

            bool shuffleCheck3 = packOfCards.shuffleCardPack(3);
            Console.WriteLine("no shuffle: "+shuffleCheck3);
            Pack.outputPack();
            Console.WriteLine("---------------\n");

            
            Pack.dealCard(10);
            Console.WriteLine("Cards that have been dealt\n");
            foreach (Card card in Pack.dealtCards)
            {
                card.outputCard();
            }

            Console.WriteLine("\nCards in pack\n");
            Pack.outputPack();
            Console.ReadKey();

        }
    }
}