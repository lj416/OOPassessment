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
            System.Console.WriteLine("Hello World");
            Pack packOfCards = new Pack();
            packOfCards.outputPack(); //output the pack 


            bool shuffleCheck1 = packOfCards.shuffleCardPack(1);
            System.Console.WriteLine("fisher yates shuffle: ",shuffleCheck1);

            bool shuffleCheck2 = packOfCards.shuffleCardPack(2);
            System.Console.WriteLine("riffle shuffle: ",shuffleCheck2);
            
            bool shuffleCheck3 = packOfCards.shuffleCardPack(3);
            System.Console.WriteLine("no shuffle: ",shuffleCheck3);

        }
    }
}