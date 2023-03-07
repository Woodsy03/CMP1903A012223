using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffler
{
    public class Program
    {

        public static List<T> RiffleShuffle<T>(List<T> Deck)
        {
            int halfSize = Deck.Count / 2;
            List<T> shuffledDeck = new List<T>();
            List<T> leftHalf = Deck.GetRange(0, halfSize);
            List<T> rightHalf = Deck.GetRange(halfSize, Deck.Count - halfSize);

            for (int i = 0; i < halfSize; i++)
            {
                shuffledDeck.Add(leftHalf[i]);
                shuffledDeck.Add(rightHalf[i]);
            }

            return shuffledDeck;
        }

        public void Main(string[] args)
        {
            List<string> Numbers = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "King", "Queen", "Ace" };
            List<string> Suites = new List<string>() { "Heart", "Spade", "Club", "Diamond" };

            // Ordered Deck Creation
            List<string> Deck = new List<string>();
            foreach (string x in Suites)
                foreach (string y in Numbers)
                    Deck.Add(y + " of " + x);


            // Prints Shuffled Output
            Console.WriteLine("This is your unshuffled deck");
            for (int i = 0; i < Deck.Count; i++)
            {
                Console.WriteLine(Deck[i]);

            }

            // Prompting user for shuffle type
            Console.WriteLine("enter a shuffle type");
            //ShuffleCardPack p = new ShuffleCardPack();
            string ShuffleType = Console.ReadLine();

            if (ShuffleType is "riffle")
            {
                Console.WriteLine("the chosen shuffle method is the Riffle Shuffle");
                Deck = RiffleShuffle(Deck);
                Console.WriteLine("your shuffled deck is");
            }

        }
    }


}





