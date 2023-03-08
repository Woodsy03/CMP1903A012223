using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffler
{
    public class Program
    {

        public static List<T> RiffleShuffle<T>(List<T> Deck)
        {
            
            int MidPoint = Deck.Count / 2; // tends towards 0 hence it will always be the lower half 
            List<T> shuffledDeck = new List<T>();
            List<T> leftHalf = Deck.GetRange(0, MidPoint);
            List<T> rightHalf = Deck.GetRange(MidPoint, Deck.Count - MidPoint);

            for (int i = 0; i < halfSize; i++)
            {
                shuffledDeck.Add(leftHalf[i]);
                shuffledDeck.Add(rightHalf[i]);
            }

            return shuffledDeck;
        }

        public static List<T> FisherYates<T>(List<T> Deck)
        {
            int length = 52;
            while (length > 0)
            {
                length = length - 1;
                Random Range = new Random();
                int Pos1 = Range.Next(length + 1);
                var cache = Deck[Pos1];
                Deck[Pos1] = Deck[length];
                Deck[length] = cache;
            }
            return Deck;
        }

        public static void Main(string[] args)
        {
            List<string> Numbers = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "King", "Queen", "Ace" };
            List<string> Suites = new List<string>() { "Hearts", "Spades", "Clubs", "Diamonds" };

            // Ordered Deck Creation
            List<string> Deck = new List<string>();
            foreach (string x in Suites)
                foreach (string y in Numbers)
                    Deck.Add(y + " of " + x);

            // Prompting user for shuffle type
            Console.WriteLine("enter a shuffle type");
            string ShuffleType = Console.ReadLine();

            
            // Selection and calling upon shuffle functions (or skipping functions if No shuffle or an invalid option if input
            if (ShuffleType is "riffle")
            {
                Console.WriteLine("the chosen shuffle method is the Riffle Shuffle");
                Deck = RiffleShuffle(Deck);
                
            }
            if (ShuffleType is "yates")
            {
                Console.WriteLine("the chosen shuffle method is the Fisher Yates Shuffle");
                Deck = FisherYates(Deck);
                
            }
            if (ShuffleType is "no shuffle")
            {
                Console.WriteLine("you have chosen no shuffle.");
            }

            else  
            {
                if (ShuffleType is "")
                {
                    Console.WriteLine("no input was provided");
                }
                else
                {
                    Console.WriteLine("That wasn't a valid shuffle type.");
                }
                    
                
            }

            for (int i = 0; i < Deck.Count; i++)
            {
                Console.WriteLine(Deck[i]);
            }
            

        }
    }


}





