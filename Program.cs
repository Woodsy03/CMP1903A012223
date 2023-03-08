using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffler
{
    public class Program
    {

        public static List<T> RiffleShuffle<T>(List<T> Deck) // The assignment was followed exactly, for real life usage, an iteration with multiple iterations of a riffle shuffle would be needed for card unpredictability. 
        {
            
            int MidPoint = Deck.Count / 2; // tends towards 0 hence it will always be the lower half 
            List<T> BlankDeck = new List<T>(); // Blank Deck created to be build upon
            List<T> BelowMidPoint = Deck.GetRange(0, MidPoint);
            List<T> AboveMidPoint = Deck.GetRange(MidPoint, Deck.Count - MidPoint);

            for (int i = 0; i < MidPoint; i++)
            {
                BlankDeck.Add(BelowMidPoint[i]); // values being added to said deck from each card side of the card cut
                BlankDeck.Add(AboveMidPoint[i]);
            }

            return BlankDeck;
        }

        public static List<T> FisherYates<T>(List<T> Deck)
        {
            int length = 52; // fixed 52 cards by assuming a single deck with no jokers - would need to be an input/calculated variable otherwise
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


        public static List<T> Deal<T>(string CardsToBeDealt, List<T> Deck)
        {
            // Final Iteration 
            int length = Int32.Parse(CardsToBeDealt);
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(Deck[i]);
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
            Console.WriteLine("How many cards would you like dealt?");
            string CardsToBeDealt = Console.ReadLine();
            Deck = Deal(CardsToBeDealt, Deck);

            
            

        }
    }


}





